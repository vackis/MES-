using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
using System.IO.Ports;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;



namespace 스마트팩토리_MES_프로젝트
{
    //test
    //test
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        static public ActUtlType PLC01 = new ActUtlType();
        public int[] x = new int[8];
        public bool start;
        public static bool[,] x_0 = new bool[8, 16];
        public int sm0;
        public int bigeumsock_Number;
        public int bisang = 0;
        public int ConveyerRotate = 0;
        public int GagongRotate = 0;
        public bool geumsock;
        public bool bigeumsock;
        public static int gagongtime = 2; //가공시간 기본값
        private bool isFlashing = false; // 깜빡임 상태를 나타내는 변수
        private int currentValue1 = 0;
        private int currentValue2 = 0;
        public static int ActCount = 1; //원하는 가공횟수
        private int ActCount_F1 = 0; //가공횟수
        public int turns;

        public int STOP = 0; //프로세스바
        public int number = 0;
        public string orgString = "";
        public int maxProgress;

        public static int steelsetting = 2;
        public static int Nsteelsetting = 1;
        public string S_steelsetting;
        public string S_Nsteelsetting;



        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Interval = 100; //타이머 간격 100ms
            timer3.Start();  //타이머 시작
            this.orgString = this.lb_percent.Text;

        }

        private void UpdateProgressBarOnCondition()
        {
            maxProgress = 100; // 최대 진행 상태
            progressBar1.Maximum = maxProgress;
            if (STOP == 0)
            {
                for (int i = 0; i <= maxProgress; i++)
                {
                    // 특정 조건에서만 ProgressBar 업데이트
                    if (i % 10 == 0) // 예를 들어, 10%마다 업데이트하려면
                    {
                        progressBar1.Value = i;
                    }
                    System.Threading.Thread.Sleep(50); // 임의의 딜레이 추가
                }
            }
        }


        private void bt_start_Click(object sender, EventArgs e)
        {
            
            start = true;
            Thread actProgram = new Thread(actPLC);
            actProgram.Start();
            number++;
            if (number > 100)
            {
                progressBar1.Value = 0;
                number = 0;
            }
         


            }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            start = false;
        }

        private void bt_modify_Click(object sender, EventArgs e)
        {
            if (start == false && turns == 0)
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }

            else
            {
                MessageBox.Show("공정이 완료되고 눌러주십시요.");
            }
        }

        private void bt_openPLC_Click(object sender, EventArgs e)  //PLC 연결
        {
            if (bt_openPLC.Text == "PLC 연결하기")
            {
                PLC01.ActLogicalStationNumber = 2;
                if (PLC01.Open() == 0)
                {
                    lb_conState.Text = "연결됨";
                    bt_openPLC.Text = "PLC 연결끊기";
                }
                else
                {
                    lb_conState.Text = "0x" + PLC01.Open();
                }
            }
            else if (bt_openPLC.Text == "PLC 연결끊기")
            {
                PLC01.Close();
                lb_conState.Text = "연결끊김";
                bt_openPLC.Text = "PLC 연결하기";
            }
        }


        private void actPLC() //실행함수
        {
            while (start)
            {
                string textfile = System.Environment.CurrentDirectory+"\\log";
                string totalNum= System.Environment.CurrentDirectory + "\\totalNum";
                string geumsockNum = System.Environment.CurrentDirectory + "\\geumsockNum";
                string bigeumsockNum = System.Environment.CurrentDirectory + "\\bigeumsockNum";
                string totalNumber_str;
                int totalNumber=0;
                if (!File.Exists(textfile))
                {
                    using (StreamWriter sw = File.CreateText(textfile))
                    {
                        
                    }
                    
                }
                if (!File.Exists(totalNum))
                {
                    using (StreamWriter sa = File.CreateText(totalNum))
                    {
                        sa.WriteLine ( "0");
                        
                    }
                }
                if (!File.Exists(geumsockNum))
                {
                    using (StreamWriter sa = File.CreateText(geumsockNum))
                    {
                        sa.WriteLine("0");

                    }
                }
                if (!File.Exists(bigeumsockNum))
                {
                    using (StreamWriter sa = File.CreateText(bigeumsockNum))
                    {
                        sa.WriteLine("0");

                    }
                }
                if (bisang == 0) // 비상정지 안눌렸을때
                {
                    // 
                    if ((x[0] & 0x0100) == 0x0100)
                    {
                        turns = 0;
                        
                          
                    }
                    else
                    {
                        start = false;
                        turns = -1;
                    }
                    while (turns == 0)
                    {
                        if (sm0 == 0)
                        {
                            if (this.InvokeRequired)//공정시작 알람
                                this.BeginInvoke((System.Action)(() =>
                                {
                                    lb_gongjungstatus.Text = "공정 진행중";
                                }));

                            if (this.InvokeRequired)       //금속, 비금속 판별여부 삭제
                            {
                                this.BeginInvoke((System.Action)(() =>
                                {
                                    lb_division.ForeColor = Color.Green;
                                    lb_division.Text = "";
                                }));
                            }

                            geumsock = false; //금속값 초기화

                            Console.WriteLine("서보준비");
                            PLC01.SetDevice("Y60", 1); //서보준비신호

                            Console.WriteLine("원점복귀");
                            long Iret = PLC01.WriteBuffer(6, 1500, 2, 9001); //원점복귀
                            PLC01.SetDevice("Y70", 1); //기동신호
                            turns++;

                        }
                     
                    }


                    while (turns == 1) //공급실린더 전진
                    {
                        Console.WriteLine("공급전진");
                        Cylinder_Forward("Y20", "Y21");

                        //퍼센트바
                        this.BeginInvoke((System.Action)(() =>
                        {
                            progressBar1.Value = 5;
                            lb_percent.Text = "5%";
                        }));


                        if ((x[1] & 0x01) == 0x01)
                        {
                            ++turns;
                        }
                    }

                    
                    while (turns == 2)
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("공급후진");
                            Cylinder_Backward("Y20", "Y21"); //공급실린더 후진

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 10;
                                lb_percent.Text = "10%";
                            }));

                            if ((x_0[1, 1]))
                            { turns++; }
                        }
                    }
                    

                    while (turns == 3)   // 가공부분
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("가공모터작동");
                            GagongRotate = 1;
                            GagongMotor_Rotate();

                            Console.WriteLine("가공모터전진");
                            PCylinder_Forward("Y26");

                            Thread.Sleep(gagongtime * 1000); //가공시간

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 15;
                                lb_percent.Text = "15%";
                            }));

                            Console.WriteLine("가공모터후진");
                            PCylinder_Backward("Y26");
                            if ((x_0[1, 2]))
                            {
                                Console.WriteLine("가공모터종료");
                                GagongMotor_Stop();
                                GagongRotate = 0;

                                //퍼센트바
                                this.BeginInvoke((System.Action)(() =>
                                {
                                    progressBar1.Value = 20;
                                    lb_percent.Text = "20%";
                                }));

                                turns++;
                            }
                        }
                    }


                    while (turns == 4) //송출실린더 전진
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("송출전진");
                            Cylinder_Forward("Y22", "Y23");
                            if (x_0[1, 4])
                            {
                                turns++;
                            }
                        }
                    }


                    while (turns == 5) //송출실린더 후진
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("송출후진");
                            Cylinder_Backward("Y22", "Y23");
                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 30;
                                lb_percent.Text = "30%";
                            }));

                            if (x_0[1, 5])
                            {
                                turns++;
                            }
                        }
                    }


                    while (turns == 6) //컨베이어벨트 작동
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("컨베이어벨트작동");
                            ConveyerBelt_Rotate();
                            ConveyerRotate = 1;

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 40;
                                lb_percent.Text = "40%";
                            }));

                            turns++;
                        }
                    }


                    while (turns == 7) // 금속, 비금속 판별
                    {
                        if (bisang == 0)
                        {
                            //Console.WriteLine("금속,비금속 판별");
                            if (x_0[0, 9])
                            {
                                geumsock = true;
                                Console.WriteLine("금속");
                                if (steelsetting == 1)
                                {
                                    S_steelsetting = "적재";
                                }
                                if (steelsetting == 2)
                                {
                                    S_steelsetting = "배출";
                                }
                                if (steelsetting == 3)
                                {
                                    S_steelsetting = "저장";
                                }


                                if (this.InvokeRequired)  //금속 판별
                                    this.BeginInvoke((System.Action)(() =>
                                    {
                                        lb_division.ForeColor = Color.Green;
                                        lb_division.Text = "금속" + S_steelsetting;
                                    }));

                                turns = 8;

                            }
                            if (x_0[0, 10])
                            {
                                if (geumsock == false)
                                {
                                    Console.WriteLine("비금속");
                                    bigeumsock = true;
                                    if (Nsteelsetting == 1)
                                    {
                                        S_Nsteelsetting = "적재";
                                    }
                                    else if (Nsteelsetting == 2)
                                    {
                                        S_Nsteelsetting = "배출";
                                    }
                                    else if (Nsteelsetting == 3)
                                    {
                                        S_Nsteelsetting = "저장";
                                    }

                                    if (this.InvokeRequired)       //비금속 판별
                                    {
                                        this.BeginInvoke((System.Action)(() =>
                                        {
                                            lb_division.ForeColor = Color.Green;
                                            lb_division.Text = "비금속" + S_Nsteelsetting;
                                        }));
                                    }
                                }
                                turns = 8;

                            }
                        }
                        //turns++;
                    }
                    // System.Environment.CurrentDirectory
                    while (turns == 8)
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine(steelsetting + "그리고" + Nsteelsetting);

                            if ((geumsock) && (steelsetting == 1))
                            {
                                Console.WriteLine("금속적재");
                                turns = 9;
                            }

                            else if ((geumsock) && (steelsetting == 2))
                            {
                                Console.WriteLine("금속배출");
                                turns = 20;
                            }

                            else if ((geumsock) && (steelsetting == 3))
                            {
                                Console.WriteLine("금속저장");
                                turns = 30;
                            }


                            else if ((!geumsock) && (Nsteelsetting == 1))
                            {
                                Console.WriteLine("비금속적재");
                                turns = 9;
                            }

                            else if ((!geumsock) && (Nsteelsetting == 2))
                            {
                                Console.WriteLine("비금속배출");
                                turns = 20;
                            }

                            else if ((!geumsock) && (Nsteelsetting == 3))
                            {
                                Console.WriteLine("비금속저장");
                                turns = 30;
                            }
                        }
                    }


                    while (turns == 9) //스톱퍼 전진및 흡착구동
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("스톱퍼전진");
                            PCylinder_Forward("Y2D");
                            if (x_0[0, 11])
                            {
                                Console.WriteLine("컨베이어정지");
                                ConveyerBelt_Stop();
                                ConveyerRotate = 0;
                                Console.WriteLine("흡착패드작동");
                                PCylinder_Forward("Y2E");
                                turns = 10;
                            }
                        }
                    }
    

                    while (turns == 10) //조그작동
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("기동신호1번");
                            PLC01.WriteBuffer(6, 1500, 2, 1);
                            PLC01.SetDevice("Y70", 1);

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 60;
                                lb_percent.Text = "60%";
                            }));

                            if (x_0[7, 4])
                            {
                                turns = 11;
                            }
                        }
                    }


                    while (turns == 11) //적재
                    {  //  bigeumsock_Number;
                        if (bisang == 0)
                        {
                            Thread.Sleep(300);
                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 70;
                                lb_percent.Text = "70%";
                            }));


                            if (bigeumsock_Number == 0)
                            {
                                Console.WriteLine("적재위치설정1-1");
                                Cylinder_Backward("Y2B", "Y2C");
                                PLC01.WriteBuffer(6, 1500, 2, 2);
                                PLC01.SetDevice("Y70", 1);
                                if (x_0[7, 4])
                                {
                                    bigeumsock_Number++;
                                    turns = 12;
                                }
                            }

                            else if (bigeumsock_Number == 1)
                            {
                                Console.WriteLine("적재위치설정1-2");
                                Cylinder_Backward("Y2B", "Y2C");
                                PLC01.WriteBuffer(6, 1500, 2, 3);
                                PLC01.SetDevice("Y70", 1);
                                if (x_0[7, 4])
                                {
                                    bigeumsock_Number++;
                                    turns = 12;
                                }
                            }

                            else if (bigeumsock_Number == 2)
                            {
                                Console.WriteLine("적재위치설정1-3");
                                Cylinder_Backward("Y2B", "Y2C");
                                PLC01.WriteBuffer(6, 1500, 2, 4);
                                PLC01.SetDevice("Y70", 1);
                                if (x_0[7, 4])
                                {
                                    bigeumsock_Number++;
                                    turns = 12;
                                }
                            }

                            else if (bigeumsock_Number == 3)
                            {
                                Console.WriteLine("적재위치설정2-1");
                                Cylinder_Forward("Y2B", "Y2C");
                                PLC01.WriteBuffer(6, 1500, 2, 2);
                                PLC01.SetDevice("Y70", 1);
                                if (x_0[7, 4])
                                {
                                    bigeumsock_Number++;
                                    turns = 12;
                                }
                            }

                            else if (bigeumsock_Number == 4)
                            {
                                Console.WriteLine("적재위치설정2-2");
                                Cylinder_Forward("Y2B", "Y2C");
                                PLC01.WriteBuffer(6, 1500, 2, 3);
                                PLC01.SetDevice("Y70", 1);
                                if (x_0[7, 4])
                                {
                                    bigeumsock_Number++;
                                    turns = 12;
                                }
                            }

                            else if (bigeumsock_Number == 5)
                            {
                                Console.WriteLine("적재위치설정2-3");
                                Cylinder_Forward("Y2B", "Y2C");
                                PLC01.WriteBuffer(6, 1500, 2, 4);
                                PLC01.SetDevice("Y70", 1);
                                if (x_0[7, 4])
                                {
                                    bigeumsock_Number++;
                                    turns = 12;
                                }
                            }

                            else //6개 적재시 
                            {
                                bigeumsock_Number = 0;
                                start = false;
                                turns = 0;
                                //turns = 0;
                            }
                        }
                    }


                    while (turns == 12) //적재 내려놓기
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("흡착패드종료");
                            Cylinder_Forward("Y29", "Y2A");

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 80;
                                lb_percent.Text = "80%";
                            }));

                            if (x_0[1, 10])
                            {
                                PCylinder_Backward("Y2E");
                                turns = 13;
                            }
                        }

                    }


                    while (turns == 13) //흡착실린더 후진
                    {
                        if (bisang == 0)
                        {
                            Console.WriteLine("흡착실린더후진");
                            Cylinder_Backward("Y29", "Y2A");

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 90;
                                lb_percent.Text = "90%";
                            }));

                            if (x_0[1, 11])
                            {
                                turns = 14;
                            }
                        }
                    }


                    while (turns == 14)
                    {
                        if (bisang == 0)
                        {
                            string NowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            if (geumsock == true)
                            {
                                if (File.Exists(textfile))
                                {

                                    using (StreamWriter sw = File.AppendText(textfile))
                                    {
                                        sw.WriteLine($"{NowTime} 금속적재\n");

                                    }
                                }
                                else
                                {

                                    MessageBox.Show("로그파일이 존재하지 않습니다.");
                                }
                            }
                            else if (bigeumsock == true)
                            {
                                if (File.Exists(textfile))
                                {

                                    using (StreamWriter sw = File.AppendText(textfile))
                                    {
                                        sw.WriteLine($"{NowTime} 비금속적재\n");

                                    }
                                }
                                else
                                {

                                    MessageBox.Show("로그파일이 존재하지 않습니다.");
                                }
                            }
                            turns = 100;
                        }
                    }


                    while (turns == 20) // 배출공정
                    {
                        if (bisang == 0)
                        {
                            Thread.Sleep(1500);
                            Console.WriteLine("배출전진");
                            Cylinder_Forward("Y24", "Y25");
                            Thread.Sleep(1500);
                            Console.WriteLine("배출후진");
                            Cylinder_Backward("Y24", "Y25");
                            Console.WriteLine("컨베이어벨트정지");
                            ConveyerBelt_Stop();
                            ConveyerRotate = 0;


                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 85;
                                lb_percent.Text = "85%";
                            }));
                            string NowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            if (geumsock == true)
                            {
                                if (File.Exists(textfile))
                                {

                                    using (StreamWriter sw = File.AppendText(textfile))
                                    {
                                        sw.WriteLine($"{NowTime} 금속배출\n");

                                    }
                                }
                                else
                                {

                                    MessageBox.Show("로그파일이 존재하지 않습니다.");
                                }
                            }
                            else if (bigeumsock == true)
                            {
                                if (File.Exists(textfile))
                                {

                                    using (StreamWriter sw = File.AppendText(textfile))
                                    {
                                        sw.WriteLine($"{NowTime} 비금속배출\n");

                                    }
                                }
                                else
                                {

                                    MessageBox.Show("로그파일이 존재하지 않습니다.");
                                }
                            }

                            turns = 100;
                        }
                    }


                    while (turns == 30) // 저장공정
                    {
                        if (bisang == 0)
                        {

                            Console.WriteLine("스톱퍼후진");
                            PCylinder_Backward("Y2D");
                            Thread.Sleep(7500);
                            Console.WriteLine("컨베이어벨트정지");
                            ConveyerBelt_Stop();
                            ConveyerRotate = 0;


                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 85;
                                lb_percent.Text = "85%";
                            }));
                            string NowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            if (geumsock == true)
                            {
                                if (File.Exists(textfile))
                                {

                                    using (StreamWriter sw = File.AppendText(textfile))
                                    {
                                        sw.WriteLine($"{NowTime} 금속저장\n");

                                    }
                                }
                                else
                                {

                                    MessageBox.Show("로그파일이 존재하지 않습니다.");
                                }
                            }
                            else if (bigeumsock == true)
                            {
                                if (File.Exists(textfile))
                                {

                                    using (StreamWriter sw = File.AppendText(textfile))
                                    {
                                        sw.WriteLine($"{NowTime} 비금속저장\n");

                                    }
                                }
                                else
                                {

                                    MessageBox.Show("로그파일이 존재하지 않습니다.");
                                }
                            }

                            turns = 100;
                        }
                    }


                    while (turns == 100) //공정 종료
                    {
                        if (bisang == 0)
                        {
                            //  geumsock = false;
                            ActCount_F1++;
                            PCylinder_Backward("Y2D");

                            //퍼센트바
                            this.BeginInvoke((System.Action)(() =>
                            {
                                progressBar1.Value = 100;
                                lb_percent.Text = "100%";
                            }));
                            if (File.Exists(totalNum))
                            {
                                using (StreamReader sr = new StreamReader(totalNum))
                                {
                                    totalNumber_str = sr.ReadToEnd();
                                    totalNumber = int.Parse(totalNumber_str) + 1;
                                }
                                using (StreamWriter sw = File.CreateText(totalNum))
                                {
                                    sw.WriteLine(totalNumber.ToString());
                                }
                            }
                            if (geumsock == true)
                            {
                                if (File.Exists(geumsockNum))
                                {
                                    using (StreamReader sr = new StreamReader(geumsockNum))
                                    {
                                        totalNumber_str = sr.ReadToEnd();
                                        totalNumber = int.Parse(totalNumber_str) + 1;
                                    }
                                    using (StreamWriter sw = File.CreateText(geumsockNum))
                                    {
                                        sw.WriteLine(totalNumber.ToString());
                                    }
                                }
                            }
                            else if (bigeumsock == true)
                            {
                                if (File.Exists(bigeumsockNum))
                                {
                                    using (StreamReader sr = new StreamReader(bigeumsockNum))
                                    {
                                        totalNumber_str = sr.ReadToEnd();
                                        totalNumber = int.Parse(totalNumber_str) + 1;
                                    }
                                    using (StreamWriter sw = File.CreateText(bigeumsockNum))
                                    {
                                        sw.WriteLine(totalNumber.ToString());
                                    }
                                }
                            }



                            Console.WriteLine("공정종료" + ActCount_F1);
                            if (ActCount == ActCount_F1) //공정횟수 비교
                            {
                                start = false;
                                ActCount_F1 = 0;

                                if (this.InvokeRequired)
                                    this.BeginInvoke((System.Action)(() =>
                                    {
                                        lb_gongjungstatus.Text = "공정 완료";
                                    }));
                            }

                            if (geumsock == true) //금속일때
                            {
                                currentValue1++; //금속 카운트

                            }
                            else //비금속일때
                            {
                                currentValue2++; //비금속 카운트
                            }


                            turns = 0;
                        }

                    }

                }
            }
        }




        void add_Text()
        {
           

           //  출처: https://developer-talk.tistory.com/147 [DevStory:티스토리]
        }
        void Cylinder_Forward(string ForwardDevice, string BackWardDevice)
        {
            PLC01.SetDevice(ForwardDevice, 1);
            PLC01.SetDevice(BackWardDevice, 0);
        }
        void Cylinder_Backward(string ForwardDevice, string BackWardDevice)
        {
            PLC01.SetDevice(ForwardDevice, 0);
            PLC01.SetDevice(BackWardDevice, 1);
        }
        void PCylinder_Forward(string Device)
        {
            PLC01.SetDevice(Device, 1);
           
        }
        void PCylinder_Backward(string Device)
        {
            PLC01.SetDevice(Device, 0);

        }
        void ConveyerBelt_Rotate()
        {
            PLC01.SetDevice("Y28", 1);
        }
        void ConveyerBelt_Stop()
        {
            PLC01.SetDevice("Y28", 0);
        }
        void GagongMotor_Rotate()
        {
            PLC01.SetDevice("Y27", 1);
           
        }
        void GagongMotor_Stop()
        {
            PLC01.SetDevice("Y27", 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //PLC에서 X00~X7F까지 값을 읽어옴
            PLC01.ReadDeviceBlock("X0", 8, out x[0]);
            for (int ct1 = 0; ct1 <= 7; ct1++)
            {
                for (int ct2 = 0; ct2 <= 15; ct2++)
                {
                    x_0[ct1, ct2] = Check_Bit(x[ct1], ct2);
                }
            }
            PLC01.GetDevice("SM0", out sm0);


            chart1.Series["금속"].Points.Clear();
            chart1.Series["금속"].Points.AddXY(chart1.Series["금속"].Points.Count, currentValue1);

            chart1.Series["비금속"].Points.Clear();
            chart1.Series["비금속"].Points.AddXY(chart1.Series["비금속"].Points.Count, currentValue2);

        }
        public static bool Check_Bit(int _data, int loc)
        {
            int val = (0x1 << loc);
            return ((int)_data & val) == val;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             PLC01.SetDevice("Y70", 0);
            /*if (bisang == 1)
            {
                ConveyerBelt_Stop();
                GagongMotor_Stop();
            }*/
        }

        private void timer3_Tick(object sender, EventArgs e)
        { // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
            lb_time.Text = DateTime.Now.ToString("F");
           
            ////// 누적 공정횟수 
            string totalNum = System.Environment.CurrentDirectory + "\\totalNum";
            string geumsockNum = System.Environment.CurrentDirectory + "\\geumsockNum";
            string bigeumsockNum = System.Environment.CurrentDirectory + "\\bigeumsockNum";


            if (File.Exists(totalNum))
            {
                using (StreamReader sr = new StreamReader(totalNum))
                {
                    label5.Text = sr.ReadToEnd();
                    //  totalNumber = int.Parse(totalNumber_str) + 1;
                }
             }
            else
            {
                using (StreamWriter sw = File.CreateText(totalNum))
                {
                    
                }
            }
             if (File.Exists(geumsockNum))
                {
                    using (StreamReader sr = new StreamReader(geumsockNum))
                    {
                        label6.Text = sr.ReadToEnd();
                     //    totalNumber = int.Parse(totalNumber_str) + 1;
                    }

                }
             else
                {
                    using (StreamWriter sw = File.CreateText(geumsockNum))
                    {

                    }
                }
            
             if (File.Exists(bigeumsockNum))
                {
                    using (StreamReader sr = new StreamReader(bigeumsockNum))
                    {
                       label7.Text = sr.ReadToEnd();
                        //   totalNumber = int.Parse(totalNumber_str) + 1;
                    }
                  
                }
             else
               {
                    using (StreamWriter sw = File.CreateText(totalNum))
                    {

                    }
                }
            
            }

        private void bt_Estop_Click(object sender, EventArgs e)
        {
            if (bisang == 0) //비상상황이 아닌 상황에서 비상버튼 누름 [비상상황 발생]
            {
                Console.WriteLine("비상정지됨");
                PLC01.SetDevice("Y64", 1);
                ConveyerBelt_Stop();
                GagongMotor_Stop();
                bisang = 1;

                if (!isFlashing)
                {
                    // 깜빡이는 타이머 시작
                    timer4.Interval = 500; // 깜빡이는 간격 설정 (예시: 500ms)
                    timer4.Start();
                    isFlashing = true; // 깜빡임 상태로 설정
                }
            }
            else //비상상황인 상황에서 비상버튼 누름 [비상상황 종료]
            {
                Console.WriteLine("비상정지해제");
                bisang = 0;
                PLC01.SetDevice("Y64", 0);
                if (GagongRotate == 1)
                {
                    GagongMotor_Rotate();
                }
                if (ConveyerRotate == 1)
                {
                    ConveyerBelt_Rotate();
                }

                {
                    // 깜빡이는 타이머 정지
                    timer4.Stop();
                    bt_Estop.BackColor = Color.Red; // 버튼 색상을 기본 빨간색으로 초기화
                    isFlashing = false; // 깜빡임 상태 해제
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (bt_Estop.BackColor == Color.DarkRed)
                bt_Estop.BackColor = Color.Red; // 기본 빨간색으로 변경
            else
                bt_Estop.BackColor = Color.DarkRed; // 어두운 빨간색으로 변경
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer4.Stop(); // 깜빡이는 타이머 정지
            bt_Estop.BackColor = Color.Red; // 버튼 색상을 기본 빨간색으로 초기화
            isFlashing = false; // 깜빡임 상태 해제
        }
        private void InitializeChart()
        {
            chart1.Series.Clear();


            // 새로운 시리즈 추가
            Series series1 = new Series
            {
                Name = "금속",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Int32,
                Color = Color.Silver // 은색으로 설정
            };
            // 새로운 시리즈 추가
            Series series2 = new Series
            {
                Name = "비금속",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Int32,
                Color = Color.Blue // 파란색으로 설정
            };

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

            // 초기 데이터 포인트 추가
            series1.Points.AddXY(0, currentValue1);
            series2.Points.AddXY(0, currentValue2);

            // 차트 설정
            chart1.ChartAreas[0].AxisX.Title = "X-Axis";
            chart1.ChartAreas[0].AxisY.Title = "Value";
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void bt_geumsock_Click(object sender, EventArgs e)
        {
            // 값 증가
            currentValue1=0;

            // 시리즈에 데이터 포인트 추가
            chart1.Series["금속"].Points.Clear();
            chart1.Series["금속"].Points.AddXY(chart1.Series["금속"].Points.Count, currentValue1);
        }

        private void bt_bigeumsock_Click(object sender, EventArgs e)
        {
            currentValue2=0;

            chart1.Series["비금속"].Points.Clear();
            chart1.Series["비금속"].Points.AddXY(chart1.Series["비금속"].Points.Count, currentValue2);
        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            Form3 frm3 =new Form3();
            //    string textfile = System.Environment.CurrentDirectory + "\\log";
            frm3.Show();

        }

       
    }

}

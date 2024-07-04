using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 스마트팩토리_MES_프로젝트
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Sujung_Click(object sender, EventArgs e)
        {
            Form1.gagongtime = int.Parse(tb_gagong.Text); //폼1의 가공시간에 텍스트박스 값을 집어넣기
            Form1.ActCount = int.Parse(tb_gongjung.Text); //폼1의 공정횟수에 텍스트박스 값을 집어넣기

            if (rb_steelload.Checked == true)
            { Form1.steelsetting = 1; }
           else if (rb_steeldispose.Checked == true)
            { Form1.steelsetting = 2; }
            else if (rb_steelsave.Checked == true)
            { Form1.steelsetting = 3; }

            if (rb_Nsteelload.Checked == true)
            { Form1.Nsteelsetting = 1; }
            else if (rb_Nsteeldispose.Checked == true)
            { Form1.Nsteelsetting = 2; }
            else if (rb_Nsteelsave.Checked == true)
            { Form1.Nsteelsetting = 3; }


            this.Close(); //닫기
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작


            tb_gagong.Text = Form1.gagongtime.ToString();
            tb_gongjung.Text = Form1.ActCount.ToString();

            rb_steeldispose.Checked = true;
            rb_Nsteelload.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
            lb_time.Text = DateTime.Now.ToString("F"); 
        }

        private void tb_gagong_TextChanged(object sender, EventArgs e)
        {
            int i_gagongtime;
            int.TryParse(tb_gagong.Text, out i_gagongtime);

            if (i_gagongtime > 10 || i_gagongtime < 0)
            {
                MessageBox.Show("1에서 10까지의 값을 넣어주십시요.", "오류");
                tb_gagong.Text = "";
            }
        }

        private void tb_gongjung_TextChanged(object sender, EventArgs e)
        {
            int i_ActCount;
            int.TryParse(tb_gongjung.Text, out i_ActCount);

            if (i_ActCount > 6 || i_ActCount < 0)
            {
                MessageBox.Show("1에서 6까지의 값을 넣어주십시요.", "오류");
                tb_gongjung.Text = "";
            }
        }

        private void rb_steelload_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

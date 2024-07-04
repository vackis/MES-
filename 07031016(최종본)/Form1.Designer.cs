namespace 스마트팩토리_MES_프로젝트
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_log = new MetroFramework.Controls.MetroButton();
            this.bt_Estop = new System.Windows.Forms.Button();
            this.bt_modify = new MetroFramework.Controls.MetroButton();
            this.bt_stop = new MetroFramework.Controls.MetroButton();
            this.bt_start = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_conState = new System.Windows.Forms.Label();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.bt_openPLC = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_percent = new System.Windows.Forms.Label();
            this.lb_division = new System.Windows.Forms.Label();
            this.lb_gongjungstatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_bigeumsock = new System.Windows.Forms.Button();
            this.bt_geumsock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_log);
            this.groupBox3.Controls.Add(this.bt_Estop);
            this.groupBox3.Controls.Add(this.bt_modify);
            this.groupBox3.Controls.Add(this.bt_stop);
            this.groupBox3.Controls.Add(this.bt_start);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(774, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(173, 387);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "공정 제어";
            // 
            // bt_log
            // 
            this.bt_log.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt_log.Location = new System.Drawing.Point(21, 240);
            this.bt_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_log.Name = "bt_log";
            this.bt_log.Size = new System.Drawing.Size(133, 39);
            this.bt_log.TabIndex = 19;
            this.bt_log.Text = "Log";
            this.bt_log.UseSelectable = true;
            this.bt_log.Click += new System.EventHandler(this.bt_log_Click);
            // 
            // bt_Estop
            // 
            this.bt_Estop.BackColor = System.Drawing.Color.Red;
            this.bt_Estop.ForeColor = System.Drawing.Color.White;
            this.bt_Estop.Location = new System.Drawing.Point(21, 320);
            this.bt_Estop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Estop.Name = "bt_Estop";
            this.bt_Estop.Size = new System.Drawing.Size(133, 42);
            this.bt_Estop.TabIndex = 18;
            this.bt_Estop.Text = "비상정지";
            this.bt_Estop.UseVisualStyleBackColor = false;
            this.bt_Estop.Click += new System.EventHandler(this.bt_Estop_Click);
            // 
            // bt_modify
            // 
            this.bt_modify.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt_modify.Location = new System.Drawing.Point(21, 182);
            this.bt_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(133, 39);
            this.bt_modify.TabIndex = 17;
            this.bt_modify.Text = "수정";
            this.bt_modify.UseSelectable = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt_stop.Location = new System.Drawing.Point(21, 118);
            this.bt_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(133, 39);
            this.bt_stop.TabIndex = 16;
            this.bt_stop.Text = "정지";
            this.bt_stop.UseSelectable = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_start
            // 
            this.bt_start.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt_start.Location = new System.Drawing.Point(21, 52);
            this.bt_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(133, 39);
            this.bt_start.TabIndex = 15;
            this.bt_start.Text = "동작";
            this.bt_start.UseSelectable = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_conState);
            this.groupBox1.Controls.Add(this.htmlLabel1);
            this.groupBox1.Controls.Add(this.bt_openPLC);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 158);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC연결";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "연결 상태 :";
            // 
            // lb_conState
            // 
            this.lb_conState.AutoSize = true;
            this.lb_conState.Location = new System.Drawing.Point(129, 102);
            this.lb_conState.Name = "lb_conState";
            this.lb_conState.Size = new System.Drawing.Size(21, 20);
            this.lb_conState.TabIndex = 16;
            this.lb_conState.Text = "-";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(107, 57);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("굴림체", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel1.Location = new System.Drawing.Point(305, 192);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(91, 40);
            this.htmlLabel1.TabIndex = 14;
            this.htmlLabel1.Text = "연결";
            // 
            // bt_openPLC
            // 
            this.bt_openPLC.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt_openPLC.Location = new System.Drawing.Point(26, 35);
            this.bt_openPLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_openPLC.Name = "bt_openPLC";
            this.bt_openPLC.Size = new System.Drawing.Size(242, 39);
            this.bt_openPLC.TabIndex = 13;
            this.bt_openPLC.Text = "PLC 연결하기";
            this.bt_openPLC.UseSelectable = true;
            this.bt_openPLC.Click += new System.EventHandler(this.bt_openPLC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_percent);
            this.groupBox2.Controls.Add(this.lb_division);
            this.groupBox2.Controls.Add(this.lb_gongjungstatus);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(328, 314);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(433, 158);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "현재 진행중 공정";
            // 
            // lb_percent
            // 
            this.lb_percent.AutoSize = true;
            this.lb_percent.Location = new System.Drawing.Point(312, 53);
            this.lb_percent.Name = "lb_percent";
            this.lb_percent.Size = new System.Drawing.Size(21, 20);
            this.lb_percent.TabIndex = 33;
            this.lb_percent.Text = "-";
            // 
            // lb_division
            // 
            this.lb_division.AutoSize = true;
            this.lb_division.Location = new System.Drawing.Point(11, 53);
            this.lb_division.Name = "lb_division";
            this.lb_division.Size = new System.Drawing.Size(21, 20);
            this.lb_division.TabIndex = 32;
            this.lb_division.Text = "-";
            // 
            // lb_gongjungstatus
            // 
            this.lb_gongjungstatus.AutoSize = true;
            this.lb_gongjungstatus.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_gongjungstatus.Location = new System.Drawing.Point(134, 44);
            this.lb_gongjungstatus.Name = "lb_gongjungstatus";
            this.lb_gongjungstatus.Size = new System.Drawing.Size(148, 30);
            this.lb_gongjungstatus.TabIndex = 19;
            this.lb_gongjungstatus.Text = "공정 대기";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 89);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(338, 42);
            this.progressBar1.TabIndex = 18;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_time.Location = new System.Drawing.Point(610, 36);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(51, 20);
            this.lb_time.TabIndex = 27;
            this.lb_time.Text = "시계";
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(23, 231);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "금속";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "Legend1";
            series26.Name = "비금속";
            this.chart1.Series.Add(series25);
            this.chart1.Series.Add(series26);
            this.chart1.Size = new System.Drawing.Size(347, 265);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart2";
            // 
            // bt_bigeumsock
            // 
            this.bt_bigeumsock.Location = new System.Drawing.Point(254, 391);
            this.bt_bigeumsock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bigeumsock.Name = "bt_bigeumsock";
            this.bt_bigeumsock.Size = new System.Drawing.Size(62, 72);
            this.bt_bigeumsock.TabIndex = 31;
            this.bt_bigeumsock.Text = "비금속\r\n리셋";
            this.bt_bigeumsock.UseVisualStyleBackColor = true;
            this.bt_bigeumsock.Click += new System.EventHandler(this.bt_bigeumsock_Click);
            // 
            // bt_geumsock
            // 
            this.bt_geumsock.Location = new System.Drawing.Point(254, 302);
            this.bt_geumsock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_geumsock.Name = "bt_geumsock";
            this.bt_geumsock.Size = new System.Drawing.Size(62, 72);
            this.bt_geumsock.TabIndex = 30;
            this.bt_geumsock.Text = "금속\r\n리셋";
            this.bt_geumsock.UseVisualStyleBackColor = true;
            this.bt_geumsock.Click += new System.EventHandler(this.bt_geumsock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(360, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "총 누적 공정횟수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(360, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "누적 금속 공정횟수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(360, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "누적 비금속 공정횟수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(619, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(619, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(619, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_bigeumsock);
            this.Controls.Add(this.bt_geumsock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Text = "PLC 공정";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton bt_modify;
        private MetroFramework.Controls.MetroButton bt_stop;
        private MetroFramework.Controls.MetroButton bt_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_conState;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton bt_openPLC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_gongjungstatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bt_Estop;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bt_bigeumsock;
        private System.Windows.Forms.Button bt_geumsock;
        private System.Windows.Forms.Label lb_division;
        private System.Windows.Forms.Label lb_percent;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton bt_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


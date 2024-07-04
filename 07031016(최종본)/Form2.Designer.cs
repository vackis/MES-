namespace 스마트팩토리_MES_프로젝트
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gongjung = new System.Windows.Forms.TextBox();
            this.tb_gagong = new System.Windows.Forms.TextBox();
            this.Sujung = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.rb_steelload = new MetroFramework.Controls.MetroRadioButton();
            this.rb_steeldispose = new MetroFramework.Controls.MetroRadioButton();
            this.gb_steelset = new System.Windows.Forms.GroupBox();
            this.rb_steelsave = new MetroFramework.Controls.MetroRadioButton();
            this.gb_Nsteelset = new System.Windows.Forms.GroupBox();
            this.rb_Nsteelsave = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Nsteeldispose = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Nsteelload = new MetroFramework.Controls.MetroRadioButton();
            this.gb_steelset.SuspendLayout();
            this.gb_Nsteelset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "공정횟수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "가공시간";
            // 
            // tb_gongjung
            // 
            this.tb_gongjung.Location = new System.Drawing.Point(226, 81);
            this.tb_gongjung.Name = "tb_gongjung";
            this.tb_gongjung.Size = new System.Drawing.Size(220, 41);
            this.tb_gongjung.TabIndex = 2;
            this.tb_gongjung.TextChanged += new System.EventHandler(this.tb_gongjung_TextChanged);
            // 
            // tb_gagong
            // 
            this.tb_gagong.Location = new System.Drawing.Point(226, 152);
            this.tb_gagong.Name = "tb_gagong";
            this.tb_gagong.Size = new System.Drawing.Size(220, 41);
            this.tb_gagong.TabIndex = 3;
            this.tb_gagong.TextChanged += new System.EventHandler(this.tb_gagong_TextChanged);
            // 
            // Sujung
            // 
            this.Sujung.Location = new System.Drawing.Point(226, 336);
            this.Sujung.Name = "Sujung";
            this.Sujung.Size = new System.Drawing.Size(189, 65);
            this.Sujung.TabIndex = 4;
            this.Sujung.Text = "돌아가기";
            this.Sujung.UseVisualStyleBackColor = true;
            this.Sujung.Click += new System.EventHandler(this.Sujung_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_time.Location = new System.Drawing.Point(534, 29);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(41, 16);
            this.lb_time.TabIndex = 28;
            this.lb_time.Text = "시계";
            // 
            // rb_steelload
            // 
            this.rb_steelload.AutoSize = true;
            this.rb_steelload.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rb_steelload.Location = new System.Drawing.Point(28, 40);
            this.rb_steelload.Name = "rb_steelload";
            this.rb_steelload.Size = new System.Drawing.Size(64, 25);
            this.rb_steelload.TabIndex = 29;
            this.rb_steelload.Text = "적재";
            this.rb_steelload.UseSelectable = true;
            this.rb_steelload.CheckedChanged += new System.EventHandler(this.rb_steelload_CheckedChanged);
            // 
            // rb_steeldispose
            // 
            this.rb_steeldispose.AutoSize = true;
            this.rb_steeldispose.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rb_steeldispose.Location = new System.Drawing.Point(28, 71);
            this.rb_steeldispose.Name = "rb_steeldispose";
            this.rb_steeldispose.Size = new System.Drawing.Size(64, 25);
            this.rb_steeldispose.TabIndex = 30;
            this.rb_steeldispose.Text = "배출";
            this.rb_steeldispose.UseSelectable = true;
            // 
            // gb_steelset
            // 
            this.gb_steelset.Controls.Add(this.rb_steelsave);
            this.gb_steelset.Controls.Add(this.rb_steeldispose);
            this.gb_steelset.Controls.Add(this.rb_steelload);
            this.gb_steelset.Location = new System.Drawing.Point(484, 63);
            this.gb_steelset.Name = "gb_steelset";
            this.gb_steelset.Size = new System.Drawing.Size(138, 152);
            this.gb_steelset.TabIndex = 33;
            this.gb_steelset.TabStop = false;
            this.gb_steelset.Text = "금속";
            // 
            // rb_steelsave
            // 
            this.rb_steelsave.AutoSize = true;
            this.rb_steelsave.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rb_steelsave.Location = new System.Drawing.Point(27, 102);
            this.rb_steelsave.Name = "rb_steelsave";
            this.rb_steelsave.Size = new System.Drawing.Size(64, 25);
            this.rb_steelsave.TabIndex = 31;
            this.rb_steelsave.Text = "저장";
            this.rb_steelsave.UseSelectable = true;
            // 
            // gb_Nsteelset
            // 
            this.gb_Nsteelset.Controls.Add(this.rb_Nsteelsave);
            this.gb_Nsteelset.Controls.Add(this.rb_Nsteeldispose);
            this.gb_Nsteelset.Controls.Add(this.rb_Nsteelload);
            this.gb_Nsteelset.Location = new System.Drawing.Point(628, 63);
            this.gb_Nsteelset.Name = "gb_Nsteelset";
            this.gb_Nsteelset.Size = new System.Drawing.Size(138, 152);
            this.gb_Nsteelset.TabIndex = 34;
            this.gb_Nsteelset.TabStop = false;
            this.gb_Nsteelset.Text = "비금속";
            // 
            // rb_Nsteelsave
            // 
            this.rb_Nsteelsave.AutoSize = true;
            this.rb_Nsteelsave.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rb_Nsteelsave.Location = new System.Drawing.Point(28, 102);
            this.rb_Nsteelsave.Name = "rb_Nsteelsave";
            this.rb_Nsteelsave.Size = new System.Drawing.Size(64, 25);
            this.rb_Nsteelsave.TabIndex = 31;
            this.rb_Nsteelsave.Text = "저장";
            this.rb_Nsteelsave.UseSelectable = true;
            // 
            // rb_Nsteeldispose
            // 
            this.rb_Nsteeldispose.AutoSize = true;
            this.rb_Nsteeldispose.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rb_Nsteeldispose.Location = new System.Drawing.Point(28, 71);
            this.rb_Nsteeldispose.Name = "rb_Nsteeldispose";
            this.rb_Nsteeldispose.Size = new System.Drawing.Size(64, 25);
            this.rb_Nsteeldispose.TabIndex = 30;
            this.rb_Nsteeldispose.Text = "배출";
            this.rb_Nsteeldispose.UseSelectable = true;
            // 
            // rb_Nsteelload
            // 
            this.rb_Nsteelload.AutoSize = true;
            this.rb_Nsteelload.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rb_Nsteelload.Location = new System.Drawing.Point(28, 40);
            this.rb_Nsteelload.Name = "rb_Nsteelload";
            this.rb_Nsteelload.Size = new System.Drawing.Size(64, 25);
            this.rb_Nsteelload.TabIndex = 29;
            this.rb_Nsteelload.Text = "적재";
            this.rb_Nsteelload.UseSelectable = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 415);
            this.Controls.Add(this.gb_Nsteelset);
            this.Controls.Add(this.gb_steelset);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.Sujung);
            this.Controls.Add(this.tb_gagong);
            this.Controls.Add(this.tb_gongjung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gb_steelset.ResumeLayout(false);
            this.gb_steelset.PerformLayout();
            this.gb_Nsteelset.ResumeLayout(false);
            this.gb_Nsteelset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_gongjung;
        private System.Windows.Forms.TextBox tb_gagong;
        private System.Windows.Forms.Button Sujung;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_time;
        private MetroFramework.Controls.MetroRadioButton rb_steelload;
        private MetroFramework.Controls.MetroRadioButton rb_steeldispose;
        private System.Windows.Forms.GroupBox gb_steelset;
        private System.Windows.Forms.GroupBox gb_Nsteelset;
        private MetroFramework.Controls.MetroRadioButton rb_Nsteeldispose;
        private MetroFramework.Controls.MetroRadioButton rb_Nsteelload;
        private MetroFramework.Controls.MetroRadioButton rb_steelsave;
        private MetroFramework.Controls.MetroRadioButton rb_Nsteelsave;
    }
}
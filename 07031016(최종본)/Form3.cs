using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 스마트팩토리_MES_프로젝트
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string textfile = System.Environment.CurrentDirectory + "\\log";
            string textfile_TEXT;
            if (File.Exists(textfile))
            {
                using (StreamReader sr = new StreamReader(textfile))
                {
                    textBox1.Text = sr.ReadToEnd();
                   //  totalNumber = int.Parse(totalNumber_str) + 1;
                }
               
            }
            else
            {
                using (StreamWriter sw = File.CreateText(textfile))
                {

                }
            }
        }
    }
}

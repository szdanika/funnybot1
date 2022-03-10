using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace funnybot1
{
    public partial class Form1 : Form
    {
        bool isRunning = true;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Elkuldtem egyszer");
            SendKeys.Send("hehe");
            SendKeys.Send("{ENTER}");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        
            Thread th = new Thread(Keyboardd);
            th.Start();
        }
        void Keyboardd()
        {
            while(isRunning)
            {

                Thread.Sleep(15);
                //SendKeys.Send("Kecske");
                //MessageBox.Show("Bent vagyok");
                if (Keys.A == (Keys.A))
                {
                    //MessageBox.Show("elindult");
                    //timerstart();
                }
                //if (Control.ModifierKeys == Keys.F1)
                    //timerStop();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
                if (IsInputKey(Keys.Escape))
                {
                    textBox1.Text = "Érzékeltem a gombot!";
                    timer1.Start();
                }
                else
                    timer1.Stop();
            */
        }
        public void timerstart()
        {
            timer1.Start();
        }
        public void timerStop()
        {
            timer1.Stop();
        }
    }
}

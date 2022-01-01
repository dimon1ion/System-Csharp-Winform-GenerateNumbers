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

namespace Work_System_Csharp_Winform
{
    public partial class Form1 : Form
    {
        public bool stopSimple = true;
        public bool pauseSimple = false;
        public bool stopFibonachi = true;
        public bool pauseFibonachi = false;
        public int min;
        public int max;
        Thread simple;
        Thread fibonachi;
        public Form1()
        {
            InitializeComponent();
            min = 0;
            max = 0;
        }

        private void GenerateSimpleNums()
        {
            bool infinity = false;
            if (min == 0)
            {
                min = 2;
            }
            if (max == 0)
            {
                infinity = true;
            }
            bool remainder;
            for (int i = min; (i < max || infinity) && !stopSimple; i++)
            {
                remainder = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        remainder = true;
                        break;
                    }
                }
                if (!remainder)
                {
                    textBox1.Text += i + " ";
                    Thread.Sleep(200);
                }
                while (pauseSimple && !stopSimple) { }
            }
            MessageBox.Show("Thread Simple stopped");
        }

        private void GenerateFibonachiNums()
        {
            // Не написано что пользователь указывает
            int firstNum = 0;
            int secNum = 1;
            int tmp;
            textBox1.Text += "0 1 ";
            while (!stopFibonachi)
            {
                textBox1.Text += (firstNum + secNum);
                tmp = secNum;
                secNum += firstNum;
                firstNum = tmp;
                Thread.Sleep(200);
                while (pauseFibonachi && !stopSimple) { }
            }
            MessageBox.Show("Thread Fibonachi stopped");
        }

        private void buttonSStart_Click(object sender, EventArgs e)
        {
            if (stopSimple == false)
            {
                MessageBox.Show("Click stop");
                return;
            }
            stopSimple = false;
            min = Convert.ToInt32(numericUpDown1.Value);
            max = Convert.ToInt32(numericUpDown2.Value);
            simple = new Thread(GenerateSimpleNums);
            simple.Start();
        }

        private void buttonSStop_Click(object sender, EventArgs e)
        {
            stopSimple = true;
        }

        private void buttonSResume_Click(object sender, EventArgs e)
        {
            pauseSimple = !pauseSimple;
        }

        private void buttonFStart_Click(object sender, EventArgs e)
        {
            if (stopFibonachi == false)
            {
                MessageBox.Show("Click stop");
                return;
            }
            stopFibonachi = false;
            min = Convert.ToInt32(numericUpDown1.Value);
            max = Convert.ToInt32(numericUpDown2.Value);
            fibonachi = new Thread(GenerateFibonachiNums);
            fibonachi.Start();
        }

        private void buttonFStop_Click(object sender, EventArgs e)
        {
            stopFibonachi = true;
        }

        private void buttonFResume_Click(object sender, EventArgs e)
        {
            pauseFibonachi = !pauseFibonachi;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopSimple = true;
            stopFibonachi = true;
            simple.Join();
            fibonachi.Join();
        }
    }
}

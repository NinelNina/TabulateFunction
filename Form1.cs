using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TabulateFunction
{
    public partial class Form1 : Form
    {
        string tmp;
        double X0;
        double XN;
        double HX;
        bool minimum;
        bool maximum;
        bool average;
        public Form1()
        {
            InitializeComponent();

            label1.Text = "X0";
            label2.Text = "XN";        
            label3.Text = "HX";
            label5.Text = "Минимальное значение функции = ";

            groupBox1.Text = "Действие";

            radioButton1.Text = "MIN";
            radioButton2.Text = "MAX";
            radioButton3.Text = "Средн. арифм.";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maximum = false;
            average = false;
            label5.Text = "Минимальное значение функции = ";
            minimum = true;
            tmp = label5.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maximum = false;
            minimum = false;
            label5.Text = "Среднее арифм. значение функции = ";
            average = true;
            tmp = label5.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            minimum = false;
            average = false;
            label5.Text = "Максимальное значение функции = ";
            maximum = true;
            tmp = label5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = tmp;

            if ((textBox1.Text != "") & (textBox2.Text != "") & (textBox3.Text != ""))
            {
                X0 = Convert.ToDouble(textBox1.Text);
                XN = Convert.ToDouble(textBox2.Text);
                HX = Convert.ToDouble(textBox3.Text);

                Solution solution = new Solution();
                label5.Text += solution.Calculate(X0, XN, HX, minimum, maximum, average);
            }
            else
            {
                MessageBox.Show("Ошибка. Введите диапазон значений X.");
            }
        }
    }
}

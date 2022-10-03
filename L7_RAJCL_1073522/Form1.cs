using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7_RAJCL_1073522
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            int A = 0;
            int B = 1;
            int C = 0;
            int i = 2;
            string resultados = "";

            if (N > 0)

            {
                resultados = resultados + Convert.ToString(A) + " , ";


                if (N > 1)
                {
                    resultados = resultados + Convert.ToString(B) + ", ";

                    while (1 < N)
                    {
                        C = A + B;
                        resultados = resultados + Convert.ToString(C);
                        A = B;
                        B = C;
                        i = i + 1;


                    }
                    label3.Text = Convert.ToString(resultados);

                }
                else
                {
                    label3.Text = Convert.ToString(resultados);
                }
            }

            else
            {
                label3.Text = Convert.ToString(resultados);

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
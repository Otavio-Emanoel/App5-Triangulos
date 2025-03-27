using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App5_Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            try {
                int A, B, C;
                A = Convert.ToInt32(lado1Txt.Text);
                B = Convert.ToInt32(lado2Txt.Text);
                C = Convert.ToInt32(lado3Txt.Text);
                if ((A < B + C) && (B < A + C) && (C < A + B))
                {
                    Console.WriteLine(" ");
                    Console.Write("Formam triângulo!");
                }
            }
            catch (Exception err)
            {

            }
        }
    }
}

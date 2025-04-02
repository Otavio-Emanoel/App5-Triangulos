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
            Close();
        }

        private void VerificarBtn_Click(object sender, EventArgs e)
        {
            try {
                int A, B, C;
                A = Convert.ToInt32(lado1Txt.Text);
                B = Convert.ToInt32(lado2Txt.Text);
                C = Convert.ToInt32(lado3Txt.Text);
                if (A <= 0 || B <= 0 || C <= 0)
                {
                    MessageBox.Show("Digite um valor para os lados do triângulo, este valor deve ser maior que zero");
                    return;
                }

                if (A == B && B == C)
                {
                    MessageBox.Show("Triângulo Equilátero");
                    return;
                }
                if (A == B || A == C || B == C)
                {
                    MessageBox.Show("Triângulo Isósceles");
                    return;
                }
                if (A != B && A != C && B != C)
                {
                    MessageBox.Show("Triângulo Escaleno");
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err.Message);
                return;
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            try
            {
                lado1Txt.Text = "";
                lado2Txt.Text = "";
                lado3Txt.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err.Message);
                return;
            }
        }
    }

}

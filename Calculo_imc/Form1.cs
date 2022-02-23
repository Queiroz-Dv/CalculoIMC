using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração de variáveis
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            //textbox recebe conteúdo da variável imc
            //definição de utilização de 2 casas decimais
            txtIMC.Text = imc.ToString("0.00");

            //Condicionais de acordo com o resultado dos cálculos
            if (imc < 18.49)
            {
                MessageBox.Show("Situação: Você está abaixo do peso",
                      "Cálculo de IMC", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
            }
            else if (imc < 24.99)
            {
                MessageBox.Show("Situação:Você com peso ideal",
                    "Cálculo de IMC", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (imc < 29.99)
            {
                MessageBox.Show("Situação: Você está acima do peso",
                      "Cálculo de IMC", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
            }
            else if (imc < 34.99)
            {
                MessageBox.Show("Ateção! Você está com Obesidade" +
                    "Grau I", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (imc < 39.99)
            {
                MessageBox.Show("Atenção! Você bestá com Obesidade" +
                    "Grau II", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Atenção! Você está com grau de " +
                   "obsidade Grau III (mórbida)", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtIMC.Text = "";
            txtPeso.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

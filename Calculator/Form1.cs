using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ModelCalculator modelCalculator;
  
        public Form1()
        {
            InitializeComponent();
            this.modelCalculator= new ModelCalculator();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }//TELINHA RESULTADO

 

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = "" + this.modelCalculator.Divisao(Convert.ToDouble(textBox1.Text));
            }//If
            else
            {
                textBox1.Text = "Insira um valor válido papi";
            }//Fim do else

            
        }//Divisao 

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelCalculator.Somar(Convert.ToDouble(textBox1.Text));
        }//Somar

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelCalculator.Subtracao(Convert.ToDouble(textBox1.Text));
        }//Subtração

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelCalculator.Multiplicar(Convert.ToDouble(textBox1.Text));
        }//Multiplicar

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelCalculator.Pot(Convert.ToDouble(textBox1.Text));
        }//Potência

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelCalculator.Raiz(Convert.ToDouble(textBox1.Text));
        }
    }//fim da classe
}//fim do projeto

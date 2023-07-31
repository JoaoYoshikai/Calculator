using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ModelCalculator
    {
        private double operacao;

        public ModelCalculator()
        {
            ConsultarOperacao = 0;
        }//fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do método

        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//Somar

        public double Subtracao(double num)
        {
            return ConsultarOperacao -= num;
        }//Subtração


    }//Fim da classe
}//Fim do projeto

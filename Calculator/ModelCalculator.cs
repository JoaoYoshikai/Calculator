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
        {if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao -= num;
        }//Subtração

        public double Divisao(double num)
        {
            if (ConsultarOperacao <= 0)
            {
               return ConsultarOperacao = num;
            }
            return ConsultarOperacao /= num;
        }//Fim da divisao

        public double Multiplicar(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao *= num;
        }//Fim da divisao

        public double Pot(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return Math.Pow(ConsultarOperacao, num);
        }//Fim da divisao

        public double Raiz(double num)
        {
            ConsultarOperacao = Math.Sqrt(num);
            return Math.Sqrt(num);
        }//Fim da divisao
    
        public double Clear()
        {
            ConsultarOperacao = 0;
            return ConsultarOperacao;
        }//Clear
    
    }//Fim da classe
}//Fim do projeto

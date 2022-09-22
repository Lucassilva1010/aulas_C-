using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Aluno
    {
         public double nota1, nota2;
        

        public double Soma()
        {
            // 1 Forma
            //return nota1 + nota2;

            double resultado = nota1 + nota2;
            return resultado;
        }

        public double Dividir()
        {
            return nota1 / nota2;
        }

        public double Multiplicar()
        {
            double resultado = nota1 * nota2;
            return resultado;
        }
    }
}

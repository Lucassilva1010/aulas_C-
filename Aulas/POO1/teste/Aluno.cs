using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Aluno
    {
       public string nome;
        public double nota1, nota2;

        public void Mensagens()
        {
            Console.WriteLine(nome + nota1);
        }

    }
}

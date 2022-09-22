using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_2
{
     class Program
    {
        static void Main(string[] args)
        {
            //Instância 

            Aluno a = new Aluno();

            a.nome = "Lucas";
            a.nota1 = 10;
            a.nota2 = 20;
            a.Mensagens();

        }
    }
}

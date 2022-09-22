using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AulaPOO_1 { 
    public class program
    {
        static void Main(string[] args)
        {
            Pessoas objPessoa = new Pessoas();

            objPessoa.nome = "Lucas";
            objPessoa.idade = 30;
            objPessoa.cpf = 9018320;

            objPessoa.mensagens();

        }
    }
}
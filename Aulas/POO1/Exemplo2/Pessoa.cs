using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    public class Pessoa
    {

        public string nome;
        public string cidade;
        public int cpf;

        public void Mensagem()
        {

          Console.WriteLine("Seja bem vindo "+nome);
        }
    }
}

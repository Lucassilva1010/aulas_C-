using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.WriteLine("Qual o seu nome?");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite um numero");
            a.nota1 = double.Parse(Console.ReadLine());

            a.Mensagens();
        }
    }
}

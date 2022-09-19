using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPara_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            for ( int i = 0; i<=numero; i++)
            {
                Console.WriteLine("Meu nome é Lucas: "+i);
                                        
            }


        }
    }
}

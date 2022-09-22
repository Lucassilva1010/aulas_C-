using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)// Metodo Principal 
        {
            Console.WriteLine("Seja bem vindo ao Programa ESCOLA!");
            
            // Instancia da classe pessoa
            Pessoa objP = new Pessoa();
            objP.
            Console.WriteLine("Digite seu nome");
            objP.nome = Console.ReadLine();

            // Instacia da Classe ALUNO
            Aluno al = new Aluno();
            Console.WriteLine("Digite a 1 Nota!");
            al.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 02");
            al.nota2 = double.Parse(Console.ReadLine());
            al.Soma();
            al.Dividir();
            al.Multiplicar();
            
            Console.WriteLine("A soma é: " + al.Soma() + "\n e a divisão é: " + al.Dividir()+" \nA multiplicação é: "+al.Multiplicar());
            Console.ReadKey();
        }
    }
}

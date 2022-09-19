using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Texto();
            TiposVariaveis();
            EntradaDeDados();
            LacoIf();
            LacoWhile();
            LacoFor();
        }
        static void Texto()
        {
            int numer1=1, numero2=9, resultado;
            resultado = numer1 + numero2;

            Console.WriteLine("Boa noite "+resultado);  
        }
        static void TiposVariaveis()
        {
            Console.WriteLine("Aqui estão as declarações de variaveis!");

            bool falsa = false;

            bool verdade = true;
            int num1 = 1;
            double numroReal = 2.1;
            float nn = 0f;
            const char nome = '@';
            string nome2 = " 2131 dadada )()787¨&%$%#@#$%¨&*()(*&¨%$#@";

            Console.WriteLine(num1+" "+ numroReal+" "+nn+" "+nome+" "+nome2+" "+verdade+" "+falsa);

        }
        static void EntradaDeDados()
        {
            Console.WriteLine("Aqui estão as Entradas de dados");

            int num1;
            double numroReal;
            string nome;
                       
            Console.WriteLine("Digiti um numero inteiro(um numeri sem virgula ','  ");
             num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digiti um numero Real(um numero com virgula ','  ");
             numroReal = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digiti um Nome  ");
             nome =Console.ReadLine();



        }
        static void LacoIf()//SE
        {
            int numero1=0, numero2 =10;

            if (numero1 >numero2)//se
            {
                Console.WriteLine("Numero MAior");
            }//fimSE
            else//se não
            {
                Console.WriteLine("Numero menor");
            }//FimElse

        }
        static void LacoWhile()//Enquanto
        {
            int cont=0, numero2 =5;

            while (cont<numero2)
            {
                Console.WriteLine("Eu sou o Melhor do SENAI!");
                cont++;//Incremeto 
                //O incremento é: cont+1
            }

        }
        static void LacoFor()//Para
        {
            int numero2 =5;

            for (int cont = 1; cont < numero2; cont++)
            {
                Console.WriteLine("Eu sou o Melhor do SENAI!");
                             
            }

        }

    }
}

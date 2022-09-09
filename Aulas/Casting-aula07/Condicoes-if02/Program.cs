using System;
public class CondicaoSE
{
    public static void Main(string[] args)
   {
        string nome;//variavel Global
        int senha = 123;//quando eu defino um valor para variavel 

        Console.WriteLine("Qual o seu nome? ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a sua Senha! ");
        senha = int.Parse(Console.ReadLine());
     

        if (nome == "lucas" &&  senha==123 )
        {

            string result = "Obrigado";//Variavel Local
            Console.WriteLine("------------------------");
            Console.WriteLine("Opaaa.. Você está autorizado!");
            Console.WriteLine("------------------------"+result);
           
        }
        else
        {
            Console.WriteLine("Longin Incorreto!");
        }
    }
}

using System;
public class CondicaoSE
{
    public static void Main(string[] args)
    {
     //Quero um programa para validar a idade uma pessoa, e saber se ela é maior de idade ou não!
        int idade;
        int acompa;

        Console.WriteLine("Qual a sua Idade? ");
        idade = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Com quantos Acompanhetes Maior de idade vc está? ");
        acompa = int.Parse(Console.ReadLine());



        if (idade>=18 && acompa>0)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Opaaa.. você é maior de idade!");
            Console.WriteLine("------------------------");
        }
        else
        {
         Console.WriteLine("Você nãoo é maior de IDade!");
         Console.WriteLine("------------------------");

        }        
    }
}

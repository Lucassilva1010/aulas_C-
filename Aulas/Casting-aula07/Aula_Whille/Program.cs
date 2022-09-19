using System;

public class AulaWhille
{
    public static void Main(string[] args)
    {
        double dinheiro, resultadoInvestimento;
        double taxaJuros, taxaInvestimento;
        int mes, contagem=1;

        Console.WriteLine("Quanto em dinheiro vc gostaria de Investir?");
        dinheiro = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a taxa de juros Mensal que vc deseja aplicar? \n Não use %!");
        taxaJuros = double.Parse(Console.ReadLine());
        taxaInvestimento = taxaJuros / 100;

        Console.WriteLine("Em quantos messes vc deseja receber o dinheiro?");
        mes = int.Parse(Console.ReadLine());

         Console.WriteLine("");
        while (contagem <= mes)
        {
            dinheiro = dinheiro + (dinheiro * taxaInvestimento);
            Console.WriteLine("O valor do "+contagem+"ª Mês investido foi de:"+dinheiro);
            contagem = contagem + 1;
        }
    
    }
}
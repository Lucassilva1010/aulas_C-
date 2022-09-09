using System;

class EntradaESaidaDeValores
{
    public static void Main(string[] args)
    {
        int numero;
        double altura;

        string nome;

        Console.WriteLine("Digite um numero para aprecer na tela! ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua Altura  para aprecer na tela! ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu nome");
        nome = Console.ReadLine();

        Console.WriteLine("Seu nome é : " + nome);
    }
}

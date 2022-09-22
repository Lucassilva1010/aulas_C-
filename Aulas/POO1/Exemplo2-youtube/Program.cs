using System;
namespace Exemplo2_youtube
{

class Exemplo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos para masi um exemplo de: " +
            "\n Encapsulamento;" +
            "\n Instância;" +
            "\n Objeto;" +
            "\n Modificadores de Acesso (Get e Set);" +
            "\n ");

        Mensagem obj = new Mensagem(); //Aqui Tem um exemplo de Instância
           // obj.mensagem = "Olá, seja bem vindo!";// aqui á um encapsulamento
            obj.SetMensagem("Eu sou o novo Metodo de Acesso!");//Acessando uma propriedade Privada, por um metodo de manipulação, com o Metodo SET "Pegar"
           Console.WriteLine( obj.GetMensagem());//aqui é uma forma de mostrar também o valor da propriedade privada, com um metodo Get"mostrar"
            obj.TextoMensagem();//Aqui também é um exemplo de Encapsulamento
        } //Todos esses exemplos são para mostrar como acontece a POO, e demostrar a sua segurança
}
}

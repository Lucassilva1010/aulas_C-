using System;

public class casting
{

    public static void Main(string[] args)
    {
        int a =10, b =20, cast;

        float pi = 3f;
        

       cast = (int)pi;// isso é um casting, Tomar cuidado ao fazer isso 

        Console.WriteLine("O valor de PI é: "+pi);
        Console.WriteLine("O valor de A é: "+a);
        Console.WriteLine("O valor de B é: "+b);

        //Perceber que o valor vai perder alguns valores, pricnipalmente como os dpeois da virgula;
        Console.WriteLine("O valor coinvertido de PI é:" + cast);

      


    }
}

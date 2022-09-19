using System;

public class Tempo
{

    public static void Main(string[] args)
    {

        Console.WriteLine("10:00");
        for (int mim=9;mim>0;mim=mim-1)
        {
            for (int seg=59;seg>=0;seg=seg-1)
            {
                Console.WriteLine(mim+":"+seg);

            }
        }
    }
}

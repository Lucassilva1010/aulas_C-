using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_1//veio de referência do outro Namespace do projeto
{
   public class Pessoas
    {
       public string nome;
       public int idade;
       public int cpf;


      public void mensagens()
        {
            Console.WriteLine("Olá,"+nome+" \n" +
                "seja bem vindo Legal que sua idade é: "+idade+
                " E seu CPF é: "+cpf);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa P = new Pessoa();
            TipoSangue tipoS = new TipoSangue();
            Menu menu = new Menu();
            P.nome = "Brenda";
            tipoS.tipo1 = "A+";
            P.Mensagem();
            tipoS.TipoDSangue();
            menu.Menuu();


        }
    }
}

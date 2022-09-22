using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2_youtube
{
    public class Mensagem
    {
       private string mensagem;

        public void TextoMensagem()
        {
            Console.WriteLine( this.mensagem);//isso para invocar ao sue proprio Objeto
        }

        public string GetMensagem()
        {
            return this.mensagem;
        }
        public void SetMensagem(string valor)
        {
            this.mensagem = valor;
        }

    }
}

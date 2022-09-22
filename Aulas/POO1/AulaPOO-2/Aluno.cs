using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO_2
{
     class Aluno
    {
        // Atributos 
        public string nome;
        public double nota1, nota2;

        // Teremos 3 Metodos

         // Media 
        public double Media()
        {
            //1 forma
            double resultado = (nota1 + nota2)/2;
            return resultado;
           
            // 2 forma
            return (nota1 + nota2) / 2;
        }
        
            // Situação 
        public string Situacao( double media)
        {
            // 1 forma - tradicional
            if (media>7)
            {
                return "Aprovado";
            }
            else
            {
                return"Reprovado";
            }
            //2 Forma 
            return media > 7 ? "Aprovado" : "Reprovado";//Ternario, também considerado como um SE
                     
        }

            // Mensagens 
        public void Mensagens()
        {
            // Declaração de variavel Local

            // Variavel para chamar o Metodo Situação 
            double mediaAluno = Media();
            
            // Variavel para chamar o Metodo Situação
            string situacaoAluno = Situacao(mediaAluno);

            // Mensagem 
            Console.WriteLine(nome + " Você está " + situacaoAluno+ " e sua Média é:"+mediaAluno );



            


        }

    }
}

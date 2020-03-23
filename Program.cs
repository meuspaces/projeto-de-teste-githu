using System;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Variaveis
           string [] Telefones = new string [3] {"(11)960616129", "(21)961691536", "(41)3451100"};

           //logica de cadastro na lista
           for(int indice = 0; indice <=2; indice++)
           {
               Console.WriteLine(indice);
               Console.WriteLine("Inserir um telefone valido");
               Telefones[indice] = Console.ReadLine();

           }

            //logica para cadastrar numero de Sao Paulo

            foreach(string Telefone in Telefones)
        
            {
                if(Telefone.StartsWith ("11"))
                Console.WriteLine(Telefone +  "O numero de telefone é de Sao Paulo");
            }
            Console.ReadLine();

           



        }
    }
}

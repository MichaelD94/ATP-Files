// Michael Douglas paim
//                    608275
//                         23/11/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_2_Michael_Douglas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codigo = { 10, 11, 12, 13, 14, 15, 16, 17};
            string[] especificacao = { "UVA", "OVO", "MEL", "TEL", "CEL", "VEU", "KEY", "NOT" };
            Double[] peso = { 1.22, 2.33, 3.44, 4.55, 5.66, 6.77, 7.88, 8.99 };
            int tamanho = codigo.Length;

            Console.WriteLine("Codigo \t Especificacao \t peso");

            for (int i = 0; i < tamanho; i++)
                
            {
                Console.WriteLine($"{codigo[i]}  \t {especificacao[i]}  \t\t {peso[i]}");
                
            }

           
           
            double media = peso.Average();

            int maisPesado = 0;

            for (int i = 0; i < codigo.Length; i++)
            {
                if (peso[i] > peso[maisPesado] )
                {
                    maisPesado = i;
                }
            }

            Console.WriteLine("\n Codigo do Mais Pesado" + codigo[maisPesado]);
            Console.WriteLine("\n O produto mais pesado e o : " + especificacao[maisPesado]);

            int maisLeve = 0;

            for (int i = 0; i < codigo.Length; i++)
            {
                if(peso[i] < peso[maisLeve])
                {
                    maisLeve = i;
                }
            }

            Console.WriteLine("\n Codigo do produto mais leve : " + codigo[maisLeve]);
            Console.WriteLine("\n O produto mais leve e o : " + especificacao[maisLeve]);

            Console.WriteLine("\n A media dos pesos dos produtos e : " + media);

            

            for (int i = 0; i < codigo.Length; i++)
            {
                if(peso[i] > media)
                {
                    Console.WriteLine("\n Este produto pesa acima da media : " + codigo[i] + "\n" + especificacao[i] + "\n" + peso[i]);
                }
            }

            string digitado;
            Console.WriteLine("Digite o codigo de um produto entre 10 e 17 ");
            digitado = Console.ReadLine();
            int aux = Convert.ToInt16(digitado);
            int produto = -1;

            for (int i = 0; i < codigo.Length; i++)
            {
                if (aux == codigo[i])
                {
                    produto = i;
                    break;
                }
            }

            if (produto != -1)
                {
                    Console.WriteLine("O produto referente ao codigo digitado e :\n" + codigo[produto] + "\n" + especificacao[produto] + "\n" + peso[produto]);
                }
                
                else
                {
                    Console.WriteLine("Burro e entre 10 e 17 deixa de ser cavalo");
                }
            
                
            Console.ReadKey();
        }
    }
}

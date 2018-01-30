using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {// tipo[] nome_vetor = new tipo[tamanho]

            string[] nomes = new string[3];
            nomes[0] = "Michael";
            nomes[1] = "Douglas";
            nomes[2] = "Paim";

            Console.WriteLine(nomes[0] + nomes[1] + nomes[2]);
            Console.WriteLine(String.Concat(nomes));

            int[] numeros = new int[3];
            numeros[0] = 1;
            numeros[1] = 4;
            numeros[2] = 5;

            int tamanho = numeros.Length;
            int soma = numeros.Sum();
            double media = numeros.Average();

            Console.WriteLine("O tamanho do vetor e de :" + tamanho);
            Console.WriteLine("Soma dos valores do vetor e de : " + soma);
            Console.WriteLine("A media dos valores do vetor e de" + media);

            int soma2 = 0;
            int i;
            double media2 = 0;
            int maior = numeros.Max();
            int menor = numeros.Min();

            for (i = 0; i < tamanho; i++)
            
                soma2 += numeros[i];

                media2 = soma2 / tamanho;

                Console.WriteLine("soma 2 = " + soma2);
                Console.WriteLine("Media 2 = " + media2);
                Console.WriteLine("Maior" + maior);
                Console.WriteLine("Menor" + menor);
            

            Console.ReadKey();
        }
    }
}

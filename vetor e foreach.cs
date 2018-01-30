using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numeros = new int[6];
            int[] numeros = { 1, 2, 6, 7, 9, 10 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            foreach(int n in numeros)
                Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}

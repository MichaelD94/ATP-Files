// Prova recuperacao Michael Douglas Paim 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_recuperacao_Michael_Douglas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codigo = new int[20];
            double[] preco = new double[20];
            Random aleatorio = new Random();
            Random aleatorio2 = new Random();
            for (int i = 0; i < codigo.Length; i++)
            {
                codigo[i] = aleatorio.Next(100, 999);
                preco[i] =  aleatorio2.Next(100, 999);
                preco [i] = preco[i] / 100;
            }

            Console.WriteLine("Codigo \t Preço");
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.WriteLine($" {codigo[i]} { preco[i]} ");
            }
            double barato = 20, caro = 0;
            int c = 0, b = 0;
            for (int i = 0; i < preco.Length; i++)
            {
                if (preco[i] < barato)
                {
                    barato = preco[i];
                    b = i;

                }
                if (preco[i] > caro)
                {
                    caro = preco[i];
                    c = i;
                }

                Console.WriteLine("O Produto mais barato");
                Console.WriteLine("Codigo : " + codigo[b] + " Preço : " + preco[b]);
                Console.WriteLine("Produto mais caro");
                Console.WriteLine("Codigo : " + codigo[c] + " Preço : " + preco[c]);
                Console.Clear();
                Console.WriteLine("Digite o codigo de um produto qualquer (100 a 999)");
                int code = Convert.ToInt32(Console.ReadLine());

                bool achou = false;

                for (int j = 0; j < codigo.Length; j++)
                { 
                    if (code == codigo[j])
                    {
                        Console.WriteLine("Codigo : " + codigo[j] + "Preço" + preco[j]);
                        achou = true;
                    }

                }

                if (achou == false)
                {
                    Console.WriteLine("Produto nao encontrado");
                }
                Console.ReadKey();
            }

        }
    }
}

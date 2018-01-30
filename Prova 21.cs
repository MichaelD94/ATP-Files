//Michael Douglas Paim
//Data 30/11/2017
//Laboratorio de ATP
//Prova 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 valores");
            double x = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            double resultado = x * (p / 100);
            Console.WriteLine("Resultado da porcentagem do primeiro numero pelo segundo " + resultado);
// oloko

            Console.WriteLine("Digite mais 2 valores");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double soma = a + b;
            Console.WriteLine("A soma dos dois numeros e : " + soma);


            int [] codigo = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            double[] preco = { 10.99, 11.99, 12.99, 13.99, 14.99, 15.99, 16.99, 17.99, 18.99, 19.99 };
            Console.WriteLine("Codigo   Preço");
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.WriteLine($"{codigo[i]} \t {preco[i]}");
            }

            Console.WriteLine("Digite o codigo do produto a ser pesquisado (10 - 19)");
            string digitado;
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
                for (int i = produto; i < codigo.Length; i++)
                {
                    
                    Console.WriteLine("Digite um percentual de aumento para o produto selecionado");
                    double percentual = Convert.ToDouble(Console.ReadLine());
                    double aumento = preco[i] * (percentual / 100);
                    Console.WriteLine("O valor do produto aumentou :" + aumento );
                    double novoPreco = preco[i] + aumento;
                    preco[i] = novoPreco;
                    break;
                }
            }

            else
            {
                Console.WriteLine("So temos produtos enumerados entre 10 e 19. Codigo digitado invalido");
            }


            Console.WriteLine("Codigo   Preço");
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.WriteLine($"{codigo[i]} \t {preco[i]}");
            }


            double[] precoNovo = {0,0,0,0,0,0,0,0,0,0};
            for (int i = 0; i < preco.Length; i++)
            {
                precoNovo[i] = preco[i] * 1.2;
            }

            Console.WriteLine("Novos preços");
            for (int i = 0; i < precoNovo.Length; i++)
            {

                Console.WriteLine(precoNovo[i]);
            }

            Console.ReadKey();
        }
    }
}

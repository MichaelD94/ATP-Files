using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMERCIO_VERA
{
    class Program
    {
        static void Main(string[] args)
        {
            int pizzas, tamanho1, tamanho2, tamanho3;
            double preco;
            string pizza_tipo;
            Console.WriteLine("Qual pizza você deseja comprar hoje?\nConsulte a tabela abaixo para se informar");
            Console.WriteLine("\t1- Frango / Tamanho 25cm\n\t2- Frango / Tamanho 30cm\n\t3- Frango / Tamanho 35cm\n\t4- Calabresa / Tamanho 25cm\n\t5- Calabresa / Tamanho 30cm\n\t6- Calabresa / Tamanho 35cm\n\t7- Presunto / Tamanho 25cm\n\t8- Presunto / Tamanho 30cm\n\t9- Presunto / Tamanho 35cm");
            pizzas = Convert.ToInt16(Console.ReadLine());
            
            switch (pizzas)
            {
                case 1:
                    pizza_tipo = "Frango";
                    preco = 18.00;
                    tamanho1 = 25;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho1, preco);
                    break;
                case 2:
                    pizza_tipo = "Frango";
                    preco = 24.00;
                    tamanho2 = 30;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho2, preco);
                    break;
                case 3:
                    pizza_tipo = "Frango";
                    preco = 30.00;
                    tamanho3 = 35;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho3, preco);
                    break;
                case 4:
                    pizza_tipo = "Calabresa";
                    preco = 18.00;
                    tamanho1 = 25;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho1, preco);
                    break;
                case 5:
                    pizza_tipo = "Calabresa";
                    preco = 24.00;
                    tamanho2 = 30;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho2, preco);
                    break;
                case 6:
                    pizza_tipo = "Calabresa";
                    preco = 30.00;
                    tamanho3 = 35;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho3, preco);
                    break;
                case 7:
                    pizza_tipo = "Presunto";
                    preco = 18.00;
                    tamanho1 = 25;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho1, preco);
                    break;
                case 8:
                    pizza_tipo = "Presunto";
                    preco = 24.00;
                    tamanho2 = 30;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho2, preco);
                    break;
                case 9:
                    pizza_tipo = "Presunto";
                    preco = 30.00;
                    tamanho3 = 35;
                    Console.WriteLine("\tPizza sabor: {0}\n\tTamanho: {1}cm\n\tPreço: R${2}", pizza_tipo, tamanho3, preco);
                    break;
                default:
                    Console.WriteLine("Não coincide");
                    break;
            }
            Console.WriteLine("Para encomendar sua pizza, ligue para o numero 7070-9090 e informe o tipo de pizza que você deseja e o endereço de entrega");
            Console.ReadKey();
        }
    }
}

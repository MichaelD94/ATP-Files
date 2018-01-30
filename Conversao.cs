using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo_conv, numeroDecimal;
            string binario = "", hexadecimal = "";
            Console.WriteLine("Informe o tipo de conversão a ser realizada: \n1- decimal para binário\n2- binário para decimal\n3- decimal para hexadecimal\n4- hexadecimal para decimal\n5- binário para hexadecimal\n6- hexadecimal para binário");
            tipo_conv = Convert.ToInt16(Console.ReadLine());
            switch (tipo_conv)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Informe o número decimal a ser convertido: ");
                    numeroDecimal = Convert.ToInt16(Console.ReadLine());
                    if (numeroDecimal == 0)
                    {
                        Console.WriteLine("Número binario:\t0000");
                    }
                    while (numeroDecimal > 0)
                    {
                        binario = (numeroDecimal % 2) + binario;
                        numeroDecimal /= 2;
                    }
                    Console.WriteLine("Número binario:\t{0}", binario);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Informe o número binário a ser convertido: ");
                    binario = Console.ReadLine();
                    numeroDecimal = Convert.ToInt32(binario, 2);
                    Console.WriteLine("Número decimal:\t{0}", numeroDecimal);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Informe o número decimal a ser convertido: ");
                    numeroDecimal = Convert.ToInt16(Console.ReadLine());
                    hexadecimal = numeroDecimal.ToString("X");
                    Console.WriteLine("Número hexadecimal:\t{0}", hexadecimal);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Informe o número hexadecimal a ser convertido: ");
                    hexadecimal = Console.ReadLine();
                    numeroDecimal = Convert.ToInt32(hexadecimal, 16);
                    Console.WriteLine("Número decimal:\t{0}", numeroDecimal);
                    break;
                case 5:
                    Console.WriteLine("Informe o número binário a ser convertido: ");
                    int binary = Convert.ToInt16(Console.ReadLine(), 2);
                    hexadecimal = Convert.ToString(binary, 16);
                    Console.WriteLine("Número hexadecimal:\t{0}", hexadecimal);
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Informe o número hexadecimal a ser convertido: ");
                    hexadecimal = Console.ReadLine();
                    hexadecimal = Convert.ToString(Convert.ToInt32(hexadecimal.ToString(), 16), 2);
                    Console.WriteLine("Número binario:\t{0}", hexadecimal);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}

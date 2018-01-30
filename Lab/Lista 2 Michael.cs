using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_2_Pedro_Henrique_Ferreira_Alves
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, medidorAtual, medidorAnterior, consumo;
            string aux;
            double cateto1, cateto2, hipotenusa, liga, cobre, niquel, ms, km, precoKwh, valor, bola, areaBola, volumeBola;
            double areaQ, areaC, areaS, raioC, ladoQ, graus, radianos, arame, areaA, raioA;

                Console.WriteLine("\n\n\n***********************************************************");
                Console.Write("Digite o número correspondente ao exercício desejado (1-8): ");
                aux = Console.ReadLine();
                opcao = Convert.ToInt32(aux);
                Console.Clear();

            if (opcao >= 1 && opcao <= 8)
            { 

                //Exercício 1 = Programa para calcular a HIPOTENUSA de um triângulo qualquer.

                if (opcao == 1)
                {
                    //Entrada de dados

                        Console.Write("\n Digite a medida do CATETO A = ");
                        cateto1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n Digite a medida do CATETO B = ");
                        cateto2 = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                    //Processamento

                        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

                    //Saída de Resultados

                        Console.WriteLine("\n As medidas dos catetos são: Cateto A = " + cateto1 + ", Cateto B = " + cateto2);
                        Console.WriteLine("\n A medida da HIPOTENUSA é = " + hipotenusa);
                        Console.ReadKey();

                }

                //Exercício 2 = Programa para determinar a QUANTIDADE de COMPONENTES em uma LIGA METÁLICA.

                if (opcao == 2)
                {

                    //Entrada de dados

                        Console.Write("\n Digite a quantida de LIGA MÉTALICA pretendida em Kg: ");
                        liga = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                    //Processamento

                        cobre = liga * 0.3;
                        niquel = liga * 0.7;

                    //Saída de Resultados

                        Console.WriteLine("\n A quantidade da LIGA METÁLICA é: " + liga + "Kg");
                        Console.WriteLine("\n A quantidade de COBRE na liga é: " + cobre + "Kg E a quantidade de NÍQUEL é: " + niquel + "Kg");
                        Console.ReadKey();
                }

                //Exercício 3 = Programa para calcular a VELOCIDADE de UM OBJETO EM QUEDA LIVRE.

                if (opcao == 3)
                {
                    //Entrada de Dados

                        Console.Write("\n Digite a VELOCIDADE do objeto em queda livre em m/s: ");
                        ms = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                    //Processamento

                        km = ms * 3.6;

                    //Saída de Resultados

                        Console.WriteLine("\n A VELOCIDADE do objeto é: " + ms + "m/s. Oque corresonde a " + km + "Km/h");
                        Console.ReadKey();

                }

                //Exercíco 4 = Programa para calcular o CONSUMO e o VALOR da ENERGIA ÉLETRICA.

                if (opcao == 4)
                {
                    //Entrada de Dados

                        Console.Write("\n Digite o número ATUAL do medidor de enérgia: ");
                        medidorAtual = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n Digite o número do MÊS ANTERIOR do medidor de energia: ");
                        medidorAnterior = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                    //Processamento e Saída de Resultados

                    if (medidorAnterior <= medidorAtual)
                    {
                        precoKwh = 0.49414;
                        consumo = medidorAtual - medidorAnterior;
                        valor = consumo * precoKwh;

                        Console.WriteLine("\n A leitura ATUAL é: " + medidorAtual);
                        Console.WriteLine("\n A leitura ANTERIOR é: " + medidorAnterior);
                        Console.WriteLine("\n O CONSUMO foi de: " + consumo + "kWh/Mês");
                        Console.WriteLine("\n O VALOR da conta é: R$" + valor);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\n Verifique a LEITURA! \n\n VALORES INVÁLIDOS!!!");
                        Console.ReadLine();
                    }

                }

                //Exercício 5 = Programa para calcular a ÁREA e o VOLUME de uma BOLA.

                if (opcao == 5)
                {
                    //Entrada de Dados

                        Console.Write("\n Digite o valor do RAIO da bola de futebol em centímetros: ");
                        bola = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                    //Processamento

                        areaBola = 4 * (Math.PI * (bola * bola));
                        volumeBola = 4 / 3 * (Math.PI * (bola * bola * bola));

                    //Saída de Resultados

                        Console.WriteLine("\n O valor do RAIO é: " + bola + "cm \n\n A ÁREA da bola é: " + areaBola + "cm² \n\n E 0 VOLUME da bola é: " + volumeBola + "cm³");
                        Console.ReadKey();
                
                }

                //Exercício 6 = Programa para calcular a ÁREA do CÍRCULO INSCRÍTO e a ÁREA do QUADRADO.
                
                if (opcao == 6)
                {
                    //Entrada de Dados

                        Console.Write("\n Digite o valor do LADO do QUADRADO em cm: ");
                        ladoQ = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                    //Processamento

                        areaQ = ladoQ * ladoQ;
                        raioC = ladoQ / 2;
                        areaC = Math.PI * (raioC * raioC);
                    
                    if (areaQ > areaC)
                    {

                        areaS = areaQ - areaC;

                    }
                    else
                    {

                        areaS = areaC - areaQ;

                    }

                    //Saída de Resultados

                        Console.WriteLine("\n A medida do LADO do Quadrado é: " + ladoQ + "cm");
                        Console.WriteLine("\n A ÁREA do QUADRADO é: " + areaQ + "cm²");
                        Console.WriteLine("\n A ÁREA do CÍRCULO é: " + areaC + "cm²");
                        Console.WriteLine("\n A ÁREA SOMBREADA é: " + areaS + "cm²");
                        Console.ReadKey();

                }

                //Exercício 7 = Programa para transformar GRAUS em RADIANOS.

                if (opcao == 7)
                {

                    //Entrada de Dados

                        Console.Write("\n Digite a medida de um ângulo em GRAUS: ");
                        graus = Convert.ToDouble(Console.ReadLine());

                    //Processamento

                        radianos = graus * (Math.PI / 180);

                    //Saída de Resultados

                        Console.WriteLine("\n A Medida em GRAUS é: °" + graus + " e corresponde a " + radianos + " RADIANOS");
                        Console.ReadKey();
           
                }

                //Exercício 8 = Programa para calcular a ÁREA de um CÍRCULO qualquer.

                if (opcao == 8)
                {

                    //Entrada de Dados

                    Console.Write("\n Digite a medida do ARAME em metros: ");
                    arame = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    //Processamento

                    raioA = arame / (2 * Math.PI);
                    areaA = Math.PI * (raioA * raioA);

                    //Saída de Resultados

                    Console.WriteLine("\n O comprimento do ARAME é: " + arame + "m");
                    Console.WriteLine("\n O RAIO da circuferência que pode ser formado com o ARAME é: " + raioA + "m");
                    Console.WriteLine("\n A ÁREA dessa circunferência é: " + areaA + "m²");
                    Console.ReadKey();

            }   }
            else
            {

                    Console.WriteLine("\n\n\n*************************************");
                    Console.WriteLine("**********OPÇÃO INVÁLIDA!!!**********");
                    Console.WriteLine("*************************************");
                    Console.ReadKey();

            }
            
        }
    }
}

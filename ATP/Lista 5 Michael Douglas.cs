//Lista de Exercícios 5 ATP
//Pedro Henrique Ferreira Alves - 604839
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;


            Console.WriteLine("\n1 - Programa escrever um vetor predefinido na ordem inversa");
            Console.WriteLine("2 - Programa para gerar 15 jogadas de dados");
            Console.WriteLine("3 - Programa para gerar 20 jogadas de dados");
            Console.WriteLine("4 - Programa para armazenar um vetor com 10 posições");
            Console.WriteLine("5 - Programa para um Hortifruti");
            Console.WriteLine("6 - Programa para gerar uma matrix 10x10");
            Console.WriteLine("7 - Programa para armazenar uma matriz de 2 colunas o peso e altura de 10 bebês");
            Console.Write("\nDigite sua opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                //Exercício 1
                //Escrever vetor definido de forma inversa

                case 1:

                    int[] vetor = { 3, 5, 7, 9 };

                    for (int i = 0; i < vetor.Length; i++)
                    {
                        Console.Write("{0}\t", vetor[i]);
                    }


                    for (int h = vetor.Length - 1; h >= 0; h--)
                    {
                        Console.Write("{0}\t", vetor[h]);
                    }

                    Console.ReadKey();
                    break;


                //Exercício 2
                //Gerar 15 jogos de dados

                case 2:

                    int[] dado = new int[15];
                    Random r = new Random();
                    int numero3 = 0, numeroPar = 0;

                    for (int i = 0; i < dado.Length; i++)
                    {
                        dado[i] = r.Next(1, 6);

                        Console.Write("\t{0}", dado[i]);

                        if (dado[i] == 3)
                        {
                            numero3++;
                        }

                        if (dado[i] % 2 == 0)
                        {
                            numeroPar++;
                        }
                    }

                    Console.WriteLine("\nO numero 3 saiu: {0} vezes.", numero3);
                    Console.WriteLine("\nNumeros pares sairam: {0} vezes.", numeroPar);
                    Console.ReadKey();

                    break;

                //Exercício 3
                //Gerar aleatoriamente 20 jogadas de dois dados

                case 3:

                    int[] dado1 = new int[20];
                    int[] dado2 = new int[20];
                    Random d = new Random();
                    int numIguais = 0, soma7 = 0;

                    for (int i = 0; i < 20; i++)
                    {
                        dado1[i] = d.Next(1, 6);
                        dado2[i] = d.Next(1, 6);
                    }

                    for (int i = 0; i < dado1.Length; i++)
                    {
                        Console.Write("{0} ", dado1[i]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");

                    for (int i = 0; i < dado2.Length; i++)
                    {
                        Console.Write("{0} ", dado2[i]);
                    }

                    Console.WriteLine();

                    for (int i = 0; i < 20; i++)
                    {
                        if (dado1[i] == dado2[i])
                        {
                            numIguais++;
                        }

                        if (dado1[i] + dado2[i] == 7)
                        {
                            soma7++;
                        }
                    }

                    Console.WriteLine("Número de vezes que o resultado dos números iguais são: {0}", numIguais);
                    Console.WriteLine("Número de vezes que a soma dos números é igual a 7 são: {0}", soma7);

                    Console.ReadKey();
                    break;

                //Exercício 4
                //Gerar e armazenar um vetor com 10 posições

                case 4:

                    int[] vetor = new int[10];
                    int v0 = 0, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0;
                    Random e = new Random();

                    for (int i = 0; i < vetor.Length; i++)
                    {
                        vetor[i] = e.Next(0, 9);

                        Console.Write("\t{0}", vetor[i]);
                    }

                    for (int i = 0; i < vetor.Length; i++)
                    {
                        if (vetor[i] == 0)
                        {
                            v0++;
                        }

                        else if (vetor[i] == 1)
                        {
                            v1++;
                        }

                        else if (vetor[i] == 2)
                        {
                            v2++;
                        }

                        else if (vetor[i] == 3)
                        {
                            v3++;
                        }

                        else if (vetor[i] == 4)
                        {
                            v4++;
                        }

                        else if (vetor[i] == 5)
                        {
                            v5++;
                        }

                        else if (vetor[i] == 6)
                        {
                            v6++;
                        }

                        else if (vetor[i] == 7)
                        {
                            v7++;
                        }

                        else if (vetor[i] == 8)
                        {
                            v8++;
                        }

                        else
                        {
                            v9++;
                        }
                    }

                    int[] vf = { v0, v1, v2, v3, v4, v5, v6, v7, v8, v9 };
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int j = 0; j < vf.Length; j++)
                    {
                        Console.Write("\t{0} = {1}", j, vf[j]);
                    }

                    Console.ReadKey();
                    break;

                //Exercício 5
                //Armazenar em um vetor especificações e preços de produtos

                case 5:

                    string[] produtos = { "mamao", "abacate", "laranja", "quiabo", "cenoura", "ovo", "melancia", "tempero", "couve", "uva" };
                    double[] precoP = { 1.50, 0.39, 4.00, 2.35, 2.55, 1.99, 2.39, 3.50, 1.00, 2.00 };
                    double[] pagar = new double[10];
                    double peso, valorTotal = 0.00, valorMercadoria;
                    int codigo, posV;

                    do
                    {
                        Console.Write("\nDigite o código do produto: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nDigite o peso do produto: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (codigo == 1)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;

                        }

                        else if (codigo == 2)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 3)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 4)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 5)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 6)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 7)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 8)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 9)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                        else if (codigo == 10)
                        {
                            posV = codigo - 1;
                            valorMercadoria = precoP[posV] * peso;
                            pagar[posV] = valorMercadoria;
                            valorMercadoria = 0.00;
                        }

                    } while (codigo > 0);

                    for (int j = 0; j < pagar.Length; j++)
                    {
                        valorTotal = valorTotal + pagar[j];
                    }

                    Console.WriteLine("{0}", valorTotal);
                    Console.ReadKey();
                    break;


                //Exercício 6
                //Gerar uma matrix 10x10

                case 6:

                    int[,] matriz = new int[10, 10];
                    Random h = new Random();

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            matriz[i, j] = h.Next(0, 10);

                            if (i == j)
                            {
                                matriz[i, j] = 1;
                            }

                            if (i == j && j < 9)
                            {
                                j = j + 1;
                                matriz[i, j] = 7;
                            }
                        }
                    }
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (i == j)
                            {
                                j = j - 1;
                                matriz[i, j] = 3;
                                j = j + 1;
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write("{0}\t", matriz[i, j]);
                        }

                        Console.WriteLine();
                    }

                    Console.ReadKey();
                    break;

                //Exercício 7
                //Armazenar uma matriz de 2 colunas o peso e altura de 10 bebês

                case 7:

                    double[,] nasce = new double[10, 2];
                    Random baby = new Random();

                    for (int i = 0; i < 10; i++)
                    {
                        for (int bebe = 0; bebe < 2; bebe++)
                        {
                            if (bebe == 0)
                            {
                                Console.Write("\nDigite o peso: ");
                                nasc[i, bebe] = Convert.ToDouble(Console.ReadLine());
                            }

                            else
                            {
                                Console.Write("\nDigite a altura: ");
                                nasc[i, bebe] = Convert.ToDouble(Console.ReadLine());
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        for (int bebe = 0; bebe < 2; bebe++)
                        {
                            Console.Write("{0}\t", nasce[i, bebe]);
                        }
                    }

                    Console.WriteLine();

                    Console.ReadKey();
                    break;

            }



        }       
          
    }
}
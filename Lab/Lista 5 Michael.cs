Lista 5 Michael Douglas Paim
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_5_LAB_ATP
{
    class Program
    {
        static void EscrevaMatriz(int[,] m)
        {
            Console.WriteLine();

            for (int l = 0; l < m.GetLength(0); l++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    Console.Write("\t{0}", m[l, c]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int opcao;

            
            Console.WriteLine("\n\t1 - Exercício 1 Gerador de idade menores que 100");
            Console.WriteLine("\t2 - Exercício 2 Gerador de jogadas Simultaneas de dados");
            Console.WriteLine("\t3 - Exercício 3 Gera um vetor com 10 produtos de uma loja");
            Console.WriteLine("\t4 - Exercício 4 Determina e escreve a porcentagem do numero de letra do Hino Nacional");
            Console.WriteLine("\t5 - Exercício 5 Gera aleatoriamente um etor com 12 numeros e organiza");
            Console.WriteLine("\t6 - Exercício 6 Gera 2 vetores com informacoes de sexo e peso");
            Console.WriteLine("\t7 - Exercício 7 Gera uma matriz de 3x3");
            Console.WriteLine("\t8 - Exercício 8 Gera dua matrizes de 3x3");
            Console.WriteLine("\t9 - Exercício 9 gera matrix 7x5");
            Console.Write("\nDigite sua opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:

                    //Exercício 1
                    //Gerar aleatoriamente a idade de 20 pessoas.

                    //Entrada de dados e Processamento                            

                    int[] v = new int[20];
                    Random aleatorio = new Random();
                    double media, maiorMedia = 0;
                    int soma = 0;

                    for (int idade = 0; idade < v.Length; idade++)
                    {
                        v[idade] = aleatorio.Next(1, 101);
                        soma = soma + v[idade];
                        media = soma / 20;

                        if (v[idade] > media)
                        {
                            maiorMedia++;
                        }
                    }

                    //Saída de Resultados

                    Console.WriteLine("\n\tA quantidade de idades maiores que a média, são: {0}", maiorMedia);

                    Console.ReadKey();
                    break;

                case 2:

                    //Exercício 2
                    //Gerar jogadas de dois dados

                    //Entrada de dados e Processamento

                    int[] d1 = new int[20];
                    int[] d2 = new int[20];
                    Random jogada = new Random();
                    int iguais = 0, valor7 = 0;                                       

                    for (int i = 0; i < d1.Length; i++)
                    {
                        d1[i] = jogada.Next(1, 6);
                        d2[i] = jogada.Next(1, 6);                        
                    }

                    Console.Write("Dado 1: ");

                    for (int i=0; i < d1.Length; i++)
                    {
                        Console.Write("  {0}", d1[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Dado 2: ");

                    for (int i= 0; i < d2.Length; i++)
                    {
                        Console.Write("  {0}", d2[i]);
                    }                  
                    
                    for(int i = 0; i < 20; i++)
                    {
                        if (d1[i] == d2[i])
                        {
                            iguais++;
                        }

                        if(d1[i] + d2[i] == 7)
                        {
                            valor7++;
                        }
                    }
                       
                    //Saída de Resultados

                    Console.WriteLine("Número de vezes que o resultado dos números são iguais: {0}", iguais);
                    Console.WriteLine("Número de vezes que a soma dos números é igual a 7: {0}", valor7);

                    Console.ReadKey();
                    break;


                case 3:

                    //Exercício 3
                    //Gerar aleatoriamente 10 preços de produtos

                    //Entrada de dados e Processamento

                    int[] preco = new int[10];
                    Random produto = new Random();
                    int menorValor = 1001, menorPosicao = 0, aux;

                    Console.WriteLine("Vetor 1");

                    for(int i= 0; i < preco.Length; i++)
                    {
                        preco[i] = produto.Next(100, 999);

                        if(preco[i] < menorValor)
                        {
                            menorValor = preco[i];
                            menorPosicao = i;
                        }
                        Console.WriteLine("{0}\t", preco[i]);
                    }

                    aux = preco[0];
                    Console.WriteLine();
                    Console.WriteLine("Vetor 2");

                    for(int i = 0; i < preco.Length; i++)
                    {
                        preco[0] = menorValor;
                        preco[menorPosicao] = aux;

                        Console.WriteLine("{0}\t", preco[i]);
                    }

                    Console.ReadKey();
                    break;


                case 5:

                    //Exercício 5
                    //Gerar um vetor com 12 números e ordená-lo

                    //Entrada de dados

                    int[] vetor = new int[12];
                    Random r = new Random();
                    int auxiliar = 0;

                    Console.Write("Vetor 1: ");

                    for(int i = 0; i < vetor.Length; i++)
                    {
                        vetor[i] = r.Next(1001);

                        Console.Write("\t{0}", vetor[i]);
                        
                        for(int j= 0; j < vetor.Length; j++)
                        {
                            if(vetor[i] < vetor[j])
                            {
                                auxiliar = vetor[i];
                                vetor[i] = vetor[j];
                                vetor[j] = auxiliar;    
                            }
                        }
                    }

                    Console.WriteLine("\n");
                    Console.Write("Vetor 1 Ordenado: ");

                    for(int k = 0; k < vetor.Length; k++)
                    {
                        Console.Write("\t{0}", vetor[k]);
                    }

                    Console.ReadKey();
                    break;



                case 6:


                    //Exercício 6
                    //Gerar dados de 25 pessoas

                    //Entrada de dados e Processsamento

                    int[] sexo = new int[25];
                    int[] peso = new int[25];
                    double mediaP = 0;
                    int somaP = 0, homem = 0, mulher = 0;
                    Random escolha = new Random();

                    for (int i = 0; i < sexo.Length; i++)
                    {
                        sexo[i] = escolha.Next(2);
                        peso[i] = escolha.Next(30, 96);
                    }

                    Console.Write("Sexo: ");

                    for (int i = 0; i < sexo.Length; i++)
                    {
                        Console.Write("   {0}", sexo[i]);
                    }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Peso: ");

                    for (int j = 0; j < peso.Length; j++)
                    {
                        Console.Write("  {0}", peso[j]);
                        somaP = somaP + peso[j];
                        mediaP = somaP / 25;                            
                    }
                    

                    Console.WriteLine("\n");
                    Console.Write("Média Aritmética dos Pesos: {0}", mediaP);
                    Console.WriteLine("\n");
                    Console.Write("Número de homens que estão com o peso acima da média: {0}", homem);
                    Console.WriteLine("\n");
                    Console.Write("Número de mulheres que estão com o peso abaixo da média: {0}", mulher);

                     
                    Console.ReadKey();
                    break;



                case 7:

                    //Exercício 7
                    //Gerar uma matriz 3x3 de números inteiros de 1 a 9

                    //Entrada de dados e Processamento

                    Random x = new Random();
                    int[,] z = new int[3, 3];
                    int[,] tz = new int[3, 3];
                    
                    for (int a = 0; a <= 2; a++)
                    {
                        for (int b = 0; b <= 2; b++)
                        {
                            z[a, b] = x.Next(1,10);
                        }
                    }

                    Console.Write("\t      Matriz");
                    EscrevaMatriz(z);

                    for (int a = 0; a < 2; a++)
                    {
                        for (int b = 0; b < 2; b++)
                        {
                            tz[b, a] = z[a, b];
                        }
                    }

                    Console.Write("\tMatriz Transposta");
                    EscrevaMatriz(tz);

                    Console.ReadKey();
                    break;
            }

            

        }
    }
}

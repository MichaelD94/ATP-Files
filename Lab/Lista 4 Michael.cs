Lista 4 Michael Douglas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            
            Console.Write("Digite o número do exercício desejado de 1 a 11: ");
            opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (opcao >= 1 && opcao <= 12)
            {

                if (opcao == 2)
                {
                    //Exercício 2
                    //Imprimir 3 números quaisquer em ordem crescente

                    int[] vetorNum = new int[3];
                    int i;

                    for (i = 0; i < 3; i++)
                    {
                        Console.Write("Digite o {0}º numero: ", i + 1);
                        vetorNum[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }

                    Array.Sort(vetorNum);

                    for (i = 0; i < 3; i++)

                        Console.WriteLine(vetorNum[i]);

                    Console.ReadKey();
                }

                if (opcao == 3)

                {
                    //Exercício 3
                    //Determinar a faixa etária de um número indeterminado de pessoas

                    int age;
                    do
                    {
                        Console.Write("Informe a idade: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (age < 18)
                        {
                            Console.WriteLine("Idade de jovens");
                        }

                        if (age >= 18 && age < 65)
                        {
                            Console.WriteLine("Adulto pagador de boleto");
                        }

                        if (age >= 65)
                        {
                            Console.WriteLine("Talvez aposentado");
                        }
                    } while (age > 0);

                    Console.ReadKey();
                }

                if (opcao == 4)
                {

                    //Exercício 4
                    //Programa para determinar senha

                    int cont;
					int senha;
                    cont = 1;

                    do
                    {
                        Console.Write("Digite a senha: ");
                        senha = Convert.ToInt16(Console.ReadLine());
                        cont = cont + 1;

                        if (senha == 1357)
                        {
                            Console.WriteLine("A senha é 1357");
                        }
                    } while (cont <= 3);

                    Console.ReadKey();
                }

                if (opcao == 6)
                {
                    //Exercício 6
                    //Determinar números pares inteiros entre dois números

                    int numA, numB;

                    Console.Write("Informe dois números inteiros: ");
                    numA = Convert.ToInt32(Console.ReadLine());
                    numB = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    for (int i = numA; i < numB; i++)
                    {
                        if (i % 2 == 0)
                            Console.Write("\t"+i);
                    }

                    Console.ReadKey();
                }

                if (opcao == 7)
                {
                    //Exercício 7
                    //Programa para calcular frações

                    int N;

                    double denominador1, denominador2, denominador_total, termo, soma;
                    denominador1 = Math.Sqrt(2);
                    denominador2 = 3;
                    soma = 0;

                    Console.Write("Informe um número inteiro positivo: ");
                    N = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (N > 0)
                    {
                        for (int numerador = 1; numerador < N; numerador++)
                        {
                            numerador = numerador++;
                            denominador1 = denominador1++;
                            denominador2 = denominador2++;
                            denominador_total = denominador1 + denominador2;
                            termo = numerador / denominador_total;
                            soma = soma + termo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Informe um valor positivo");
                    }

                    Console.WriteLine("A soma dos " + N + " valores da série é: " + soma);
                    Console.ReadKey();
                }

                if (opcao == 8)
                {
                    //Exercício 8
                    //Programa para calcular o quadrado de um número

                    int N;

                    Console.Write("Digite um número inteiro positivo: ");
                    N = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (N > 0)
                    {
                        for (int i = 1; i < N; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.WriteLine(i);
                                Console.WriteLine("O quadrado do número é: " + Math.Pow(i++, 2));
                            }
                        }
                    }

                    Console.ReadKey();
                }

                if (opcao == 9)
                {
                    //Exercício 9
					// Exibe os numeros com as mesmas caracteristicas de 30+25

                    int numero1, numero2;

                    for (int i = 1000; i < 9999; i++)
                    {
                        numero1 = i / 100;
                        numero2 = i % 100;

                        if ((numero1 + numero2) * (numero1 + numero2) == i)
                        {
                            Console.WriteLine("O número " + i + " tem a mesma caraceterística do número 3025");
                        }
                    }
                    Console.ReadKey();
                }

                if (opcao == 10)
                {
                    //Exercício 10
					//Perca da massa do material radioativo.
                    double massaIn, massaFin, diminui, X, tempo;

                    Console.Write("Informe a massa do material radioativo: ");
                    massaIn = Convert.ToDouble(Console.ReadLine());
                    diminui = massaIn * 0.25;
                    X = massaIn / 0.5;
                    massaFin = massaIn - (diminui * X);
                    tempo = 18100 * X;
                    Console.Clear();

                    Console.WriteLine("Descrescimento é: " + diminui + " a cada 5 horas e 3 minutos");
                    Console.WriteLine("X: " + X);
                    Console.WriteLine("A massa final é: " + massaIn);
                    Console.WriteLine("O tempo decorrido é: " + tempo + "seg");

                    Console.ReadKey();
                }

                if (opcao == 11)
                {
                    //Exercício 11
                    //Lê sexo e idade de um numero indeterminado de pessoas.

                    int idade, media_idade_masc, idade_masc, contador_idade;
                    double peso, media_peso_fem, peso_fem, contador_peso;
                    int sexo;

                    idade_masc = 0;
                    contador_idade = 1;
                    peso_fem = 0;
                    contador_peso = 1;

                    do
                    {
                        Console.Write("Digite sua Idade, Peso e Sexo : (0 para Feminino e 1 para Masculino)");
                        idade = Convert.ToInt32(Console.ReadLine());
                        peso = Convert.ToDouble(Console.ReadLine());
                        sexo = Convert.ToInt32(Console.ReadLine());
                        contador_idade = contador_idade++;
                        contador_peso = contador_peso++;
                        Console.Clear();

                        if (sexo == 1)
                        {
                            idade_masc = idade_masc + idade;
                            media_idade_masc = idade_masc / contador_idade;
                            Console.WriteLine("Média da idade dos homens: " + media_idade_masc);
                        }

                        if (sexo == 0)
                        {
                            peso_fem = peso_fem + peso;
                            media_peso_fem = peso_fem / contador_peso;
                            Console.WriteLine("Média do peso das mulheres: " + media_peso_fem);
                        }

                    } while (idade > 0);

                    Console.ReadKey();
                }


                Console.ReadKey();
            }

        }          
    }
}

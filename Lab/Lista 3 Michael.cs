//Lista de Exercícios 3 LAB ATP
//Pedro Henrique Ferreira Alves - 604839
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, destino;
            double code, x, y, pot, i, salBruto, salLiquido, impr, inss, triArea, p, side1, side2, side3, angulo, freteFix, freteVar, freteT;
            string nomeF;
            char resposta;



            
                Console.Write("\nDigite o número do exercício(1 a 7): ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            

            //Exercício 1
            //Gerar dígito verificador
            if (opcao == 1)
            {
                //Entrada de dados

                do
                {
                    Console.Write("\nDigite o código do produto: ");
                    code = Convert.ToInt32(Console.ReadLine());

                    //Processamento

                    y = Math.Pow((code - 357), 2);
                    x = y % 10;

                    //Saída de Resultados

                    Console.WriteLine("Código e Dígito: " + code + "-" + x);

                } while (code != 0);

                Console.ReadKey();
            }

            //Exercício 2
            //Programa para calcular a potência de 2 de 1 a 32

            if (opcao == 2)
            {
                //Processamento e Saída de Resultados

                Console.WriteLine("Esses são os quadrados dos numeros inteiros de 1 a 32");
            for (int i = 1; i <= 32; i++)
            {
                int num = i * i;
                Console.WriteLine(num);
            }
            Console.ReadKey();
            }

            //Exercício 3
            //Determinar todos o números inteiros < 1000 divisíveis por 7 e 11

            if (opcao == 3)
            {
                //Processamento e Saída de Resultados

                for (int num = 1; num < 1000; numero++)
                {
                    if ((num % 7 == 0) && (num % 11 == 0))
                    {
                        Console.Write("\t" + num);
                    }
                }
                Console.ReadKey();
            }

            //Exercício 4
            //Cálculo de descontos e valor líquido de um salário

            if (opcao == 4)
            {
                //Entrada de Dados
                do
                {
                    Console.Write("\n Nome do Funcionario: ");
                    nomeF = Console.ReadLine();
                    Console.Write("\nValor do salario bruto: ");
                    salBruto = Convert.ToDouble(Console.ReadLine());

                    if (salBruto == 0)
                    {
                        break;
                    }
                    Console.Clear();

                    //Processamento

                    if (salBruto <= 890)
                    {
                        impr = 0;
                        inss = (salBruto * 8) / 100;
                        salLiquido = salBruto - impr - inss;
                    }

                    else if (salBruto > 890 && salBruto <= 3560)
                    {
                        impr = (salBruto * 15) / 100;
                        inss = (salBruto * 9) / 100;
                        salLiquido = salBruto - impr - inss;
                    }

                    else
                    {
                        ir = (salBruto * 27.5) / 100;
                        inss = (salBruto * 11) / 100;
                        salLiquido = salBruto - impr - inss;
                    }

                    //Saída de Resultados

                    if (ir == 0)
                    {
                        Console.WriteLine("\nNome do Funcionario: {0}", nomeF);
                        Console.WriteLine("\nSalário Bruto: {0}", salBruto);
                        Console.WriteLine("\nImposto de Renda: ISENTO");
                        Console.WriteLine("\nINSS: {0}", inss);
                        Console.WriteLine("\nSalário Líquido: {0}", salLiquido);
                    }

                    else
                    {
                        Console.WriteLine("\nNome do Funcionario: {0}", nomeF);
                        Console.WriteLine("\nSalário Bruto: {0}", salBruto);
                        Console.WriteLine("\nImposto de Renda: {0}", ir);
                        Console.WriteLine("\nINSS: {0}", inss);
                        Console.WriteLine("\nSalário Líquido: {0}", salLiquido);
                    }

                    Console.ReadKey();
                    Console.Clear();

                } while (salBruto != 0);

                Console.ReadKey();
            }

            //Exercício 5
            //Identificar as medidas de um triângulo e calcular a sua área 

            if (opcao == 5)
            {
                //Entrada de Dados

                do
                {
                    Console.Write("\nDigite um número REAL POSITIVO: ");
                    side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nDigite um outro número REAL POSITVO: ");
                    side2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nDigite um terceiro número REAL POSITIVO: ");
                    side3 = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    //Processamento

                    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
                    {
                        p = (side1 + side2 + side3) / 2;
                        triArea = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

                        //Saída de Resultados

                        Console.WriteLine("\nAs medidas do triangulo são: {0}, {1}, {2}", side1, side2, side3);
                        Console.WriteLine("\nE a sua area é: {0:F2}", triArea);
                    }

                    else
                    {
                        Console.WriteLine("\nOs valores não podem ser medidas dos lados de um triangulo.");
                    }

                    Console.ReadKey();
                    Console.Clear();

                } while (lado1 > 0 && lado2 > 0 && lado3 > 0);

            }

            //Exercício 6
            //Programa para determinar em qual quadrante do cículo trigonométrico um ângulo está

            if (opcao == 6)
            {
                //Entrada de Dados

                do
                {
                    Console.Write("\nDigite um grau qualquer de um ângulo: ");
                    angulo = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    //Processamento e Saída de Resultados

                    if (angulo >= 0 && angulo <= 90)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Primeiro Quadrante.");
                    }

                    else if (angulo >= 91 && angulo <= 180)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Segundo Quadrante.");
                    }

                    else if (angulo >= 181 && angulo <= 270)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Terceiro Quadrante.");
                    }

                    else if (angulo >= 271 && angulo <= 380)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Quarto Quadrante.");
                    }

                    else if (angulo <= -1 && angulo >= -90)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Quarto Quadrante.");
                    }

                    else if (angulo <= -91 && angulo >= -180)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Terceiro Quadrante.");
                    }

                    else if (angulo <= -181 && angulo >= -270)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Segundo Quadrante.");
                    }

                    else if (angulo <= -271 && angulo >= 360)
                    {
                        Console.WriteLine("\nEste Ângulo Pertence ao Primeiro Quadrante.");
                    }

                    else
                    {
                        Console.WriteLine("\nÂngulo Inválido!");
                    }

                    Console.ReadKey();

                    Console.Clear();

                    //Para repetir o pragama, foi preciso fazer esta estrutura, já que o valor do ângulo, pode ser qualquer número real

                    Console.Write("\nDeseja analisar outro ângulo? S= Sim e N= Não: ");
                    resposta = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    if (resposta == 'n' || resposta == 'N')
                    {
                        break;
                    }

                    while (resposta != 'N' && resposta != 'n' && resposta != 'S' && resposta != 's')
                    {
                        Console.WriteLine("\n***RESPOSTA INVÁLIDA!!!*** \nDigite S para Sim ou N para Não.");
                        Console.WriteLine("\nDeseja analisar outro ângulo? ");
                        resposta = Convert.ToChar(Console.ReadLine());
                    }

                } while (resposta != 'N' || resposta != 'n');
            }

            //Exercício 7
            //Programa para calcular o custo de um frete, dependendo do seu destino

            if (opcao == 7)
            {
                //Entrada de Dados

                do
                {

                    Console.WriteLine("\n1 - Norte de Minas.");
                    Console.WriteLine("2 - Sul de Minas.");
                    Console.WriteLine("3 - Oeste de Minas.");
                    Console.WriteLine("4 - Leste de Minas.");
                    Console.Write("\nDigite sua opção: ");
                    destino = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    //Processamento e Saída de Resultados

                    switch (destino)
                    {
                        case 1:

                            Console.Write("\nDigite o Valor do Frete Fixo: ");
                            freteFix = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            freteVar = freteFix * 0.5;
                            freteT = freteFix + freteVar;

                            Console.WriteLine("\nDestino: Norte de Minas.");
                            Console.WriteLine("\nFrete Fixo: {0}", freteFix);
                            Console.WriteLine("\nFrete Variável: {0}", freteVar);
                            Console.WriteLine("\nValor Frete total: {0}", freteT);

                            Console.ReadKey();
                            break;

                        case 2:

                            Console.Write("\nDigite o Valor do Frete Fixo: ");
                            freteFix = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            freteVar = freteFix * 0.4;
                            freteT = freteFix + freteVar;

                            Console.WriteLine("\nDestino: Sul de Minas.");
                            Console.WriteLine("\nFrete Fixo: {0}", freteFix);
                            Console.WriteLine("\nFrete Variável: {0}", freteVar);
                            Console.WriteLine("\nValor Total do Frete: {0}", freteT);

                            Console.ReadKey();
                            break;

                        case 3:

                            Console.Write("\nDigite o Valor do Frete Fixo: ");
                            freteFix = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            freteVar = freteFix * 0.3;
                            freteT = freteFix + freteVar;

                            Console.WriteLine("\nDestino: Oeste de Minas.");
                            Console.WriteLine("\nFrete Fixo: {0}", freteFix);
                            Console.WriteLine("\nFrete Variável: {0}", freteVar);
                            Console.WriteLine("\nValor Total do Frete: {0}", freteT);

                            Console.ReadKey();
                            break;

                        case 4:

                            Console.Write("\nDigite o Valor do Frete Fixo: ");
                            freteFix = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            freteVar = freteFix * 0.2;
                            freteT = freteFix + freteVar;

                            Console.WriteLine("\nDestino: Leste de Minas.");
                            Console.WriteLine("\nFrete Fixo: {0}", freteFix);
                            Console.WriteLine("\nFrete Variável: {0}", freteVar);
                            Console.WriteLine("\nValor Total do Frete: {0}", freteT);

                            Console.ReadKey();
                            break;
                    }

                    Console.Clear();


                } while (destino > 0 && destino < 5);

            }
      
            Console.ReadKey();

        }
        
    }
}

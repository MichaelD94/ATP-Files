using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {   //Calculo de pessoas com doencas usando como base natalidade e mortalidade.

            //Criando os vetores
            int[] natalidade = new int[15];
            int[] mortalidade = new int[15];
            int[] nataliMortali = new int[15];
            int[] natalidadeQuad = new int[15];

            //Colocando valor nos vetores de Natalidade e Mortalidade
            Console.WriteLine("Digite a taxa de natalidade dos ultimos 15 meses");
            for (int i = 0; i < natalidade.Length; i++)
            {
                string aux = Console.ReadLine();
                natalidade[i] = Convert.ToInt32(aux);
            }
            Console.WriteLine("Digite a taxa de mortalidade dos ultimos 15 meses");
            for (int i = 0; i < mortalidade.Length; i++)
            {
                string aux = Console.ReadLine();
                mortalidade[i] = Convert.ToInt32(aux);
            }
            // Calculando e guardando os valores nos vetores de Somatoria Natalidade * Mortalidade
            for (int i = 0; i < nataliMortali.Length; i++)
            {
                nataliMortali[i] = natalidade[i] * mortalidade[i];
            }
            // Calculando e guardando os valores dos Quadrados da Natalidade
            for (int i = 0; i < natalidadeQuad.Length; i++)
            {
                natalidadeQuad[i] = natalidade[i] * natalidade[i];
            }
            //Calculando a soma dos Vetores
            int somaNataMorta = nataliMortali.Sum();
            int somaNatalidade = natalidade.Sum();
            int somaMortalidade = mortalidade.Sum();
            int somaNatalidadeQuad = natalidadeQuad.Sum();
            //Calculando a Media dos Vetores
            double mediaNatalidade = natalidade.Average();
            double mediaMortalidade = mortalidade.Average();
            //Calculando o valor de A e B para o calculo de Regressão
            double valorA = 15 * somaNataMorta - somaNatalidade * somaMortalidade / 15 * somaNatalidadeQuad - somaNatalidade * somaNatalidade;
            double valorB = mediaMortalidade - valorA * mediaNatalidade;
            // Finalizando a Equação de Y para obter o valor da Regressão. 
            Console.WriteLine("Digite agora o valor de X para a Resolução da equação");
            string aux2 = Console.ReadLine();
            double valorX = Convert.ToDouble(aux2);
            double equacaoY = valorA * valorX + valorB;

            Console.WriteLine("O resultado da Regressão Linear e : " + equacaoY);
            Console.ReadKey();

        }
    }
}

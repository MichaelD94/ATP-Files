using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamento
{
    class Program
    {
        static void Main(string[] args)
        {// Calculo de Financiamento

            // Interação com o Usuario
            Console.WriteLine(" Vamos Calcular Rapidinho quanto Você pagará por aquele emprestimo ou financiamento");
            Console.WriteLine("que você ja fez ou ainda vai fazer. Será que compensa ?");
            Console.WriteLine("Quer mesmo saber ??(Digite S ou N para Sim ou Nao e aperte Enter)");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                //Coleta de Dados para o Cálculo
                Console.WriteLine("Me diga Primeiro: Qual o valor que Você pretende pegar");
                string aux = Console.ReadLine();
                double emprestimo = Convert.ToDouble(aux);
                Console.WriteLine("Agora me diga de quantas vezes pretende dividir o pagamento");
                string aux2 = Console.ReadLine();
                double numParcelas = Convert.ToDouble(aux2);
                Console.WriteLine("Por ultimo me informe a taxa de juros ao mês do seu Banco ou Financeira ");
                string aux3 = Console.ReadLine();
                double jurosMes = Convert.ToDouble(aux3);
                //Calculando as parcelas e o valor Total do Financiamento ou Empréstimo
                double valorParcela = (emprestimo / numParcelas) * jurosMes / 100;
                double valorTotal = valorParcela * numParcelas;
                Console.Clear();
                //Informando os Resultados ao Usuario
                Console.WriteLine("O Valor das parcelas do seu Financiamento/Emprestimo e de R$ " + valorParcela);
                Console.WriteLine("O valor total do seu Financiamento/Emprestimo e de R$" + valorTotal);
            }

            if (resposta == "n")
            {
                Console.WriteLine("Espero poder Ajudar em outro momento. Volte quando quiser saber mais sobre Financiamentos e Emprestimos. Ate Breve");
            }
            else
            {
                Console.WriteLine("Por favor digite apenas S ou N para Sim ou Nao e aperte Enter para que eu possa te ajudar.");
                
            }

            Console.ReadKey();
        }
    }
}

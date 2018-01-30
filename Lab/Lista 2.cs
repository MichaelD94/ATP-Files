Lista 2 
Michael Douglas Paim

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Lista 2 
            // Exercicio 1: Calculo da medida da Hipotenusa
            string cateto1;
            string cateto2;

            Console.WriteLine("Digite o valor do primeiro cateto");
            cateto1 = Console.ReadLine();
            double aux1 = Convert.ToDouble(cateto1);
            Console.WriteLine("Digite o valor do segundo cateto");
            cateto2 = Console.ReadLine();
            double aux2 = Convert.ToDouble(cateto2);

            double hipo = aux1 * aux1 + aux2 * aux2;
            double hipotenusa = Math.Sqrt(hipo);

            Console.WriteLine("O valor dos catetos e : " + aux1 + "  " + aux2);
            Console.WriteLine(" E o valor da hipotenusa e : " + hipotenusa );

            Console.ReadKey();
        }
    }
}

----------------------------------------------------------------------------------------------------------------------------------------

static void Main(string[] args)
        {
            // Lista 2 
            // Exercicio 2: Calculo de uma liga metalica 30% niquel e 70% cobre

            string liga;
            double niquel;
            double cobre;

            Console.WriteLine("Digite a quantidade de liga que voce pretende obrter");
            liga = Console.ReadLine();
            double aux = Convert.ToDouble(liga);
            niquel = aux * 0.3;
            cobre = aux * 0.7;

            Console.WriteLine("Para obter " + aux + " de liga voce precisa de " + niquel + " de niquel e " + cobre + " de cobre");

            Console.ReadKey();
        }
		
----------------------------------------------------------------------------------------------------------------------------------------

static void Main(string[] args)
        {
            // Lista 2 
            // Exercicio 3: Conversao de m/s para km/h de um objeto em queda livre

            string aux;
            Console.WriteLine("Digite a velocidade do objeto em m/s");
            aux = Console.ReadLine();
            double metros = Convert.ToDouble(aux);
            double kmh = metros * 3.6 ;

            Console.WriteLine("Um objeto caindo a uma velocidade de " + metros + " m/s esta caindo a " + kmh + " Km/h");
            Console.ReadKey();

        }

-------------------------------------------------------------------------------------------------------------------------------------------

		static void Main(string[] args)
        {
            // Lista 2 
            // Exercicio 4: calculo Conta cemig

            double quiloWatt = 0.7825;
            string aux;
            string aux2;

            Console.WriteLine("Digite a leitura antiga do seu padrao de Energia ");
            aux = Console.ReadLine();
            Console.WriteLine("Digite a leitura atual do seu padrao de Energia ");
            aux2 = Console.ReadLine();

            int leituraAntiga = Convert.ToInt32(aux);
            int leituraAtual = Convert.ToInt32(aux2);

            int consumo = leituraAtual - leituraAntiga;

            double valorConta = consumo * quiloWatt;

            Console.WriteLine("Leitura Anterior " + leituraAntiga);
            Console.WriteLine("Leitura Atual " + leituraAtual);
            Console.WriteLine("Seu consumo foi de : " + consumo + " kilowatts");
            Console.WriteLine("E o valor a pagar pela sua conta e de : " + valorConta);

            Console.ReadKey();

        }
--------------------------------------------------------------------------------------------------------------------------------------------


static void Main(string[] args)
        {
            //Lista 2
            // Exercicio 5 : Calcular a area e o volume de uma bola com o valor de raio dado pelo usuario.

            string aux;
            Console.WriteLine("Digite o valor do raio da bola que voce quer obter area e volume");
            aux = Console.ReadLine();
            double raio = Convert.ToDouble(aux);

            double area = 4 * Math.PI * (raio * raio);
            double volume = 4 / 3 * Math.PI * (raio * raio * raio);

            Console.WriteLine("Uma bola de Raio " + raio);
            Console.WriteLine("tem area igual a : " + area + "E volume igual a : " + volume);
            Console.ReadKey();
        }
----------------------------------------------------------------------------------------------------------------------------------------------

static void Main(string[] args)
        {
            //Lista 2 
            //Exercicio 7: Convertendo Graus em Radianos

            string aux;

            Console.WriteLine("Digite o valor em graus que deseja converter para radianos");
            aux = Console.ReadLine();
            double graus = Convert.ToDouble(aux);
            double radianos = (graus * Math.PI) / 180;
            Console.WriteLine("Medida em graus " + graus);
            Console.WriteLine("Convertido para Radianos " + radianos);
            Console.ReadKey();
        }		


		
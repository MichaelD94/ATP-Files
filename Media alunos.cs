using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {    //Uma escola te contratatou para fazer um aplicativo que realize a media das notas dos akunos de uma sala
            // lembrando que atualmente a sala tem 5 alunos e as notas vao de 0 a 10.
            Console.WriteLine("Media De alunos");

            float soma = 0;
            float media = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + i + ":");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;
            }

            media = soma / 5;
            Console.WriteLine("A media das notas dos alunos desta sala foi de: " + media);
            Console.ReadKey();

        }
    }
}

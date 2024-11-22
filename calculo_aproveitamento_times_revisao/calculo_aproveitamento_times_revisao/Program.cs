using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_aproveitamento_times_revisao
{
    internal class Program
    {
               
        static double Aproveitamento (double qtdpontos, double qtdjogos)
        {
            return qtdpontos / (qtdjogos * 3) * 100;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("O programa abaixo irá calcular a porcentagem de aproveitamento de cada time");

            var times = new List<(string Nome, int Pontos, int Jogos, double Aproveitamento)>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome do time : ");
                string time = Console.ReadLine();

                Console.Write("Digite o número de pontos do time : ");
                int pontos = int.Parse(Console.ReadLine());

                Console.Write("Digite o número de jogos do time : ");
                int jogos = int.Parse(Console.ReadLine());

                Console.Write("\n");

                double aproveitamento = Aproveitamento(pontos,jogos);

                times.Add((time, pontos, jogos, aproveitamento));
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nResultado dos Times : ");
            Console.ResetColor();

            foreach (var dados in times)
            {
                Console.ForegroundColor = ConsoleColor.Green
                    ;
                Console.WriteLine($"\nO time {dados.Nome} obteve {dados.Pontos} pontos em {dados.Jogos} jogos");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Aproveitamento : {dados.Aproveitamento:F1}%");
                Console.ResetColor();
            }

            Console.ReadKey();
        
        }
    }
}

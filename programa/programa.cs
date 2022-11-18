using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juju_iluminada
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pontos = new int[5];
            string[] times = new string[5];
            for (int i = 0; i < times.Length; i++){
                Console.WriteLine("Qual o nome do teu time?");
                times[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Quantos pontos seu time fez?");
                pontos[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("! Fim :P !");
            Console.ReadKey();
        }
    }
}

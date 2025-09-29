using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milhas milhas = new Milhas();

            Console.WriteLine("CONVERSOR DE MILHAS EM QUILÔMETROS");
            Console.WriteLine("Coloque as milhas que você quer converter:");

            int quantidadeMilhas = int.Parse(Console.ReadLine());
            milhas.SetMilhas(quantidadeMilhas);
            milhas.Calcular();
            Console.WriteLine("CONVERTENDO em kms:" + milhas.GetQuilometro());
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("coloque a base do seu triangulo");
            int b = int.Parse(Console.ReadLine());
            triangulo.setBase(b);

            Console.WriteLine("Agora coloque a altura do seu triangulo");
            int h = int.Parse(Console.ReadLine());

            triangulo.setAltura(h);
            triangulo.Calcularea();

            Console.WriteLine("A area do seu triangulo é:" + triangulo.getArea());
            Console.Write("...");


        }
    }
}

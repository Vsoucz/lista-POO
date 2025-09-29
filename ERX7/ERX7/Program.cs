using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERX7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cotação cotacao = new Cotação();

            Console.WriteLine("Qual é a cotação do dólar? (arredonde para número inteiro):");
            int cotacaoDoDolar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantos dólares você tem? :");
            int quantidadeDeDolares = Convert.ToInt32(Console.ReadLine());

            cotacao.SetCotacaoDoDolar(cotacaoDoDolar);
            cotacao.SetQuantidadeDeDolares(quantidadeDeDolares);

            cotacao.CalcularValorEmReais();

            Console.WriteLine("O valor em reais é: R$ " + cotacao.GetValorEmReais());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERX7
{
    internal class Cotação
    {
        private int cotacaoDoDolar;
        private int quantidadeDeDolares;
        private int valorEmReais;

        public void SetCotacaoDoDolar(int cotacao)
        {
            this.cotacaoDoDolar = cotacao;
        }

        public void SetQuantidadeDeDolares(int quantidade)
        {
            this.quantidadeDeDolares = quantidade;
        }

        public void CalcularValorEmReais()
        {
            this.valorEmReais = this.cotacaoDoDolar * this.quantidadeDeDolares;
        }

        public int GetValorEmReais()
        {
            return this.valorEmReais;
        }
    }
}

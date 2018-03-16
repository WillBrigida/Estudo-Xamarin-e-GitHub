using System;
using System.Collections.Generic;
using System.Text;

namespace ListaXamarin.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeDeItens { get; set; }


        public override string ToString()
        {
            return $"ID do Produto: {this.IdProduto}\n" +
                $"Nome do Produto: {this.NomeProduto}\n" +
                $"Quantidade de Itens: {this.QuantidadeDeItens}" ;
        }

    }
}

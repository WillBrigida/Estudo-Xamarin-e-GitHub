using System;
using System.Collections.Generic;
using System.Text;

namespace ListaXamarin.Models
{
    public class Item
    {
        public int IdItem { get; set; }
        public string NomeItem { get; set; }
        public decimal ValorItem { get; set; }


        public override string ToString()
        {
            return $"Codigo do Item: {this.IdItem}\n" +
                $"Nome do Item: {this.NomeItem}\n" +
                $"Valor do Item: {this.ValorItem}"; 
        }
    }
}

using ListaXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.MultiSelectListView;

namespace ListaXamarin.ViewModels
{
    public class ProdutosViewModel : BaseViewModel
    {
        //public MultiSelectObservableCollection<Produto> Produtos { get; set; }
        public ObservableCollection<Produto> Produtos { get; set; }


        public ProdutosViewModel()
        {
            Produtos = new ObservableCollection<Produto>
            {
                new Produto{IdProduto = 1001, NomeProduto = "Arroz", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1002, NomeProduto = "Feijão", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1003, NomeProduto = "Farinha", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1004, NomeProduto = "Macarrão", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1005, NomeProduto = "Leite", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1006, NomeProduto = "Açucar", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1007, NomeProduto = "Sal", QuantidadeDeItens = 0 },
                new Produto{IdProduto = 1008, NomeProduto = "Óleo", QuantidadeDeItens = 0 },
            
            };
        }
    }
}


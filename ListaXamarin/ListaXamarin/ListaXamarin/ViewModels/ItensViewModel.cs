using ListaXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaXamarin.ViewModels
{
    public class ItensViewModel : BaseViewModel
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set {this.SetProperty(ref nome , value); }
        }

        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set {this.SetProperty(ref valor , value); }
        }



    }
}

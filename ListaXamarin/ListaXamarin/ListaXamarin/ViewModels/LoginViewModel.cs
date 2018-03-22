using GalaSoft.MvvmLight.Command;
using ListaXamarin.IServices;
using System;
using System.Windows.Input;
using Xamarin.Forms;


namespace ListaXamarin.ViewModels
{
    public class LoginViewModel : Models.BaseViewModel
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { this.SetProperty( ref email , value); }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set
            {
                if (this.senha != value)
                {
                    this.SetProperty(ref senha, value);
                }
            }
        }

        private bool isEnabled;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set {this.SetProperty( ref isEnabled , value); }
        }

        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set {this.SetProperty(ref isRunning , value); }
        }


        private readonly INavigationService _navigationService;

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {


                await Application.Current.MainPage.DisplayAlert(
                    "Ops!",
                    "Você esqueceu de digitar seu Email",
                    "Ok");
                return;
            }



            if (string.IsNullOrEmpty(this.Senha))
            {

                await Application.Current.MainPage.DisplayAlert(
                "Ops!",
                "Você esqueceu de digitar sua senha",
                "Ok");

                return;
            }




            if (this.Email != "will_brigida@hotmail.com" || this.Senha != "123456")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Ops!",
                    "Login e/ou Senha inválidos! Verifique os dados informados e tente novamente",
                    "Ok");
                return;
                

            }
            else
            {
                await this._navigationService.NavigateToMain();
            }
        }

        public LoginViewModel()
        {
            this.IsEnabled = true;
            this._navigationService = DependencyService.Get<INavigationService>();

        }
    }
}

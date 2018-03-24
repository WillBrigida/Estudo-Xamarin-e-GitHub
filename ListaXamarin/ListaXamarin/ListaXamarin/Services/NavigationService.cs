using ListaXamarin.IServices;
using ListaXamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaXamarin.Services
{
    class NavigationService : INavigationService
    {
        #region INavigationService implementation

        public async System.Threading.Tasks.Task NavigateToLogin()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

        public async System.Threading.Tasks.Task NavigateToItensView()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ItensView());
        }

        public async System.Threading.Tasks.Task NavigateToMain()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        #endregion
    }
}

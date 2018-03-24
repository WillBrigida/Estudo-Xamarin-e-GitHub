using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaXamarin.IServices
{
    public interface INavigationService
    {
        Task NavigateToLogin();
        Task NavigateToItensView();
        Task NavigateToMain();
    }
}

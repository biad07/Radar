using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Radar.ViewModels
{
    public class MainViewModel:Conductor<object>
    {
        private LoginViewModel _loginVM;
        public MainViewModel(LoginViewModel loginVM) 
        {
            LoginVM = loginVM;
            ActivateItemAsync(LoginVM);
        }

        public LoginViewModel LoginVM { get => _loginVM; set => _loginVM = value; }
    }
}

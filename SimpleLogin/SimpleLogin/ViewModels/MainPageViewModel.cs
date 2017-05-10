using SimpleLogin.Helpers;
using SimpleLogin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleLogin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        public ICommand LogoutCommand { get; set; }
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MainPageViewModel() {
            LogoutCommand = new Command(Logout);
            Message = "Welcome to Main Page!";
        }

        private async void Logout()
        {
            Settings.IsLoggedIn = false;
            await Navigation.PushAsync(new LoginPage());
        }
    }
}

using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace douleiaDEMO.ViewModels
{
    public class MyProfileViewModel : BaseViewModel
    {
        public MyProfileViewModel()
        {
            Title = "My Profile";
            if(douleiaDEMO.LocalAPI.AccountService.getUser())
            {
                ButtonName = "Sign in";
            }
            else
            {
                ButtonName = "Create new Account";
            }
        }

        ICommand createAccount { get; set; }
    }
}

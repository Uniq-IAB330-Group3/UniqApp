using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Uniq.Models;
using Xamarin.Forms;

namespace Uniq.ViewModels
{
    public class ManualViewModel : BaseViewModel
    {
        private string description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public string Description {
            get => description;
            set => SetProperty(ref description, value);
        }
    }
}

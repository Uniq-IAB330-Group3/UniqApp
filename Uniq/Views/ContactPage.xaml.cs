using System.ComponentModel;
using Xamarin.Forms;
using Uniq.ViewModels;

namespace Uniq.Views
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel();
        }
    }
}
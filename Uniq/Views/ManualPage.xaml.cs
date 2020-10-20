using System.ComponentModel;
using Xamarin.Forms;
using Uniq.ViewModels;

namespace Uniq.Views
{
    public partial class ManualPage : ContentPage
    {
        public ManualPage()
        {
            InitializeComponent();
            BindingContext = new ManualViewModel();
        }
    }
}
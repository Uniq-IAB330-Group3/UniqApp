using System.ComponentModel;
using Xamarin.Forms;
using Uniq.ViewModels;

namespace Uniq.Views
{
    public partial class ExtensionPage : ContentPage
    {
        public ExtensionPage()
        {
            InitializeComponent();
            BindingContext = new ExtensionViewModel();
        }
    }
}
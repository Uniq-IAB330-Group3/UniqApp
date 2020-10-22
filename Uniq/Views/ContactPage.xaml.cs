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
        void MessagesListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e) {

        }
    }
}
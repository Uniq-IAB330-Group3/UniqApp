using Uniq.ViewModels;
using Xamarin.Forms;

namespace Uniq.Views {
    public partial class TalkPage : ContentPage {
        public TalkPage() {
            InitializeComponent();
            BindingContext = new TalkViewModel();
        }

        void MessagesListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e) {

        }
    }
}
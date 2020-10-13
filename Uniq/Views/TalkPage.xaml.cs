using Uniq.ViewModels;
using Xamarin.Forms;

namespace Uniq.Views {
    public partial class TalkPage : ContentPage {
        public TalkPage() {
            InitializeComponent();
            BindingContext = new TalkViewModel();
        }
    }
}
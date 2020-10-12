using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uniq.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanListViewPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PlanListViewPage()
        {
            InitializeComponent();
        }

        void CheckBox_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            
        }
    }
}

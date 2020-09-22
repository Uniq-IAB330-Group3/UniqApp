using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Uniq.Views
{
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ChatPage selectedItem = e.SelectedItem as ChatPage;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ChatPage tappedItem = e.Item as ChatPage;
        }
    }
}

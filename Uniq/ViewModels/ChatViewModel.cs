using System;
using System.Collections.ObjectModel;
using Uniq.Models;
using MvvmHelpers;
using Xamarin.Forms;
using Uniq.Views;

namespace Uniq.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        public ObservableCollection<Chat> Chats { get; set; }

        public Command TapCommand { get; }

        public ChatViewModel()
        {
            SetupData();
            //Title = "Chat Page";

            TapCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new CellsPage());
            });
        }

        void SetupData()
        {
            Chats = new ObservableCollection<Chat>()
            {
                new Chat
                {
                    Name = "John",
                    Content = "Hi, How are you?",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "David",
                    Content = "That's a good idea",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                }
            };
        }
    }
}

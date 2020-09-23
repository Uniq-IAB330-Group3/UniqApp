using System;
using System.Collections.ObjectModel;
using Uniq.Models;

namespace Uniq.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        public ObservableCollection<Chat> Chats { get; set; }

        public ChatViewModel()
        {
            SetupData();
            Title = "Chat Page";
        }

        void SetupData()
        {
            Chats = new ObservableCollection<Chat>()
            {
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                },
                new Chat
                {
                    Name = "John Smith",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfilePicture = "user1.png",
                    Time = "Tue 11:32am"
                }
            };
        }
    }
}

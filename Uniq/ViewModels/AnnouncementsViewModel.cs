using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Uniq.Models;
using Uniq.Views;

namespace Uniq.ViewModels
{
    public class AnnouncementsViewModel : BaseViewModel
    {
        public ObservableCollection<Announcement> Announcements { get; set; }

        public AnnouncementsViewModel()
        {
            SetupData();

            Title = "Announcements";
        }

        void SetupData()
        {
            Announcements = new ObservableCollection<Announcement>()
            {
                new Announcement
                {
                    Name = "John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "user1.png",
                    TimePosted = "Tue 11:32am"
                },
                new Announcement
                {
                    Name = "David Webb",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProfileImage = "user2.png",
                    TimePosted = "Tue 8:11am"
                },
                new Announcement
                {
                    Name = "Jane Goodman",
                    Unit = "IAB153",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImage = "user3.png",
                    TimePosted = "Mon 8:44pm"
                },
                new Announcement
                {
                    Name = "Josh Grier",
                    Unit = "CAB321",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.",
                    ProfileImage = "user4.png",
                    TimePosted = "Mon 8:29pm"
                },
                new Announcement
                {
                    Name = "Anthony Galletly",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "user5.png",
                    TimePosted = "Fri 12:14pm"
                }

            };
       


        }

    }
}
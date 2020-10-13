using System.Collections.ObjectModel;
using Uniq.Models;
using Xamarin.Forms;
using System.Diagnostics;
using System;

namespace Uniq.ViewModels
{
    public class AnnouncementsViewModel : BaseViewModel
    {
        public ObservableCollection<Announcement> Announcements { get; set; }

        public ObservableCollection<UnitFilter> UnitFilters { get; set; }

        public AnnouncementsViewModel()
        {
            SetupData();

            Title = "Announcements";

            _filterVisible = false;

            ShowFilter = new Command(DisplayFilter);
        }

        public Command ShowFilter { get; }

        private Boolean _filterVisible;
        public Boolean FilterVisible
        {
            get { return _filterVisible; }
            set { _filterVisible = value; }
        }

        void SetupData()
        {
            Announcements = new ObservableCollection<Announcement>()
            {
                new Announcement
                {
                    Title = "John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "user1.png",
                    TimePosted = "Tue 11:32am"
                },
                new Announcement
                {
                    Title = "David Webb",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProfileImage = "user2.png",
                    TimePosted = "Tue 8:11am"
                },
                new Announcement
                {
                    Title = "Jane Goodman",
                    Unit = "IAB153",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImage = "user3.png",
                    TimePosted = "Mon 8:44pm"
                },
                new Announcement
                {
                    Title = "Josh Grier",
                    Unit = "CAB321",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.",
                    ProfileImage = "user4.png",
                    TimePosted = "Mon 8:29pm"
                },
                new Announcement
                {
                    Title = "Anthony Galletly",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "user5.png",
                    TimePosted = "Fri 12:14pm"
                }
            };

            UnitFilters = new ObservableCollection<UnitFilter>()
            {
                new UnitFilter
                {
                    UnitId = "CAB202",
                    SelectedIcon = "tick.png"
                },
                new UnitFilter
                {
                    UnitId = "CAB321",
                    SelectedIcon = "cross.png"
                },
                new UnitFilter
                {
                    UnitId = "IAB123",
                    SelectedIcon = "tick.png"
                },
                new UnitFilter
                {
                    UnitId = "CAB123",
                    SelectedIcon = "tick.png"
                }
            };
        }

        void DisplayFilter()
        {
            Debug.WriteLine("filter test");
            FilterVisible = !FilterVisible;
            OnPropertyChanged(nameof(FilterVisible));
        }
    }
}
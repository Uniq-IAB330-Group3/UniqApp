using System.Collections.ObjectModel;
using Uniq.Models;
using Xamarin.Forms;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using MvvmHelpers;

namespace Uniq.ViewModels
{
    public class AnnouncementsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Announcement> Announcements { get; set; }

        public ObservableCollection<UnitFilter> UnitFilters { get; set; }

        public AnnouncementsViewModel()
        {
            SetupData();

            Title = "Announcements";

            ShowFilter = new Command(DisplayFilter);

            UnitFilterToggle = new Command<UnitFilter>((_unit) => UnitToggle(_unit));
        }

        public Command ShowFilter { get; }

        public Command UnitFilterToggle { get; }

        private bool _filterVisible;
        public bool FilterVisible
        {
            get { return _filterVisible; }
            set { _filterVisible = value; }
        }

        private UnitFilter _unit;
        public UnitFilter Unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;

                if (_unit == null)
                    return;

                UnitFilterToggle.Execute(_unit);

                Unit = null;
            }
        }
        void SetupData()
        {
            _filterVisible = false;

            Announcements = new ObservableRangeCollection<Announcement>()
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

            string primaryColor = "#03bfff";
            string secondaryColor = "#FFF";
            
            UnitFilters = new ObservableCollection<UnitFilter>()
            {
                new UnitFilter
                {
                    UnitId = "CAB202",
                    SelectedIcon = "tick.png",
                    Status = true,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new UnitFilter
                {
                    UnitId = "CAB321",
                    SelectedIcon = "cross.png",
                    Status = true,
                    BtnColor = secondaryColor,
                    TextColor = "#000"
                },
                new UnitFilter
                {
                    UnitId = "IAB153",
                    SelectedIcon = "tick.png",
                    Status = true,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new UnitFilter
                {
                    UnitId = "CAB123",
                    SelectedIcon = "tick.png",
                    Status = true,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                }
            };
        }

        void DisplayFilter()
        {
            FilterVisible = !FilterVisible;
            OnPropertyChanged(nameof(FilterVisible));
        }

        void UnitToggle( UnitFilter _unit)
        {
            Debug.WriteLine(_unit.BtnColor + " " + _unit.UnitId);

            _unit.BtnColor = "#FFF";
            OnPropertyChanged(nameof(Unit));

            //Announcements.ReplaceRange(AllItems.Where)
        }
    }
}
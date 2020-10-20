using System.Collections.ObjectModel;
using Uniq.Models;
using Xamarin.Forms;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using MvvmHelpers;
using System.Linq;

namespace Uniq.ViewModels
{
    public class AnnouncementsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Announcement> Announcements { get; set; }

        public ObservableRangeCollection<Announcement> AllAnnouncements { get; set; }

        public ObservableCollection<UnitFilter> UnitFilters { get; set; }

        public Command ShowFilter { get; }

        public Command ShowSortBy { get; }

        public Command GroupByUnit { get; }

        public Command GroupByAnnouncer { get; }

        public Command UnitFilterToggle { get; }

        private bool _filterVisible;
        public bool FilterVisible
        {
            get { return _filterVisible; }
            set { _filterVisible = value; }
        }

        private bool _sortByVisible;
        public bool SortByVisible
        {
            get { return _sortByVisible; }
            set { _sortByVisible = value; }
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

        public AnnouncementsViewModel()
        {
            SetupData();

            Title = "Announcements";

            ShowFilter = new Command(DisplayFilter);

            ShowSortBy = new Command(DisplaySortBy);

            GroupByUnit = new Command(GroupByU);

            GroupByAnnouncer = new Command(GroupByA);

            UnitFilterToggle = new Command<UnitFilter>((_unit) => UnitToggle(_unit));

        }

        void SetupData()
        {
            _filterVisible = false;

            Announcements = new ObservableRangeCollection<Announcement>();

            AllAnnouncements = new ObservableRangeCollection<Announcement>()
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
                },
                new Announcement
                {
                    Name = "Lucy Matthews",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProfileImage = "user6.png",
                    TimePosted = "Fri 8:59am"
                },
                new Announcement
                {
                    Name = "Toby Batchler",
                    Unit = "CAB321",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.",
                    ProfileImage = "user7.png",
                    TimePosted = "Thu 9:29pm"
                },
                new Announcement
                {
                    Name = "David Webb",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImage = "user2.png",
                    TimePosted = "Thu 11:11am"
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
                    Status = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new UnitFilter
                {
                    UnitId = "CAB321",
                    SelectedIcon = "cross.png",
                    Status = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new UnitFilter
                {
                    UnitId = "IAB153",
                    SelectedIcon = "tick.png",
                    Status = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new UnitFilter
                {
                    UnitId = "CAB123",
                    SelectedIcon = "tick.png",
                    Status = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new UnitFilter
                {
                    UnitId = "All",
                    SelectedIcon = "tick.png",
                    Status = true,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                }
            };

            Announcements.ReplaceRange(AllAnnouncements);
        }

        void DisplayFilter()
        {
            FilterVisible = !FilterVisible;
            OnPropertyChanged(nameof(FilterVisible));
        }

        void DisplaySortBy()
        {
            SortByVisible = !SortByVisible;
            OnPropertyChanged(nameof(SortByVisible));
        }

        void GroupByU()
        {
            Announcements = new ObservableRangeCollection<Announcement>(Announcements.OrderBy(a => a.Unit).ToList());

            OnPropertyChanged(nameof(Announcements));
        }

        void GroupByA()
        {
            Announcements = new ObservableRangeCollection<Announcement>(Announcements.OrderBy(a => a.Name).ToList());

            OnPropertyChanged(nameof(Announcements));
        }

        //void OnCheckBoxCheckedChanged()
        //{
        //    UnitToggle(Unit);
        //}

        void UnitToggle( UnitFilter unit)
        {
            unit.BtnColor = "#FFF";

            unit.Status = !unit.Status;
            OnPropertyChanged(nameof(Unit.Status));
            Debug.WriteLine(Unit.UnitId + " " + Unit.Status);

            if (unit.Status)
            {
                unit.SelectedIcon = "tick.png";
            } else
            {
                unit.SelectedIcon = "cross.png";
            }
            OnPropertyChanged(nameof(Unit.SelectedIcon));


            if (unit.UnitId != "All")
            {
                Announcements.ReplaceRange(AllAnnouncements.Where(a => a.Unit == unit.UnitId));
            }
            else
            {
                Announcements.ReplaceRange(AllAnnouncements);
            }

        }
    }
}
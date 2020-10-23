using System.Collections.ObjectModel;
using Uniq.Models;
using Uniq.Views;
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

        public ObservableCollection<Filter> UnitFilters { get; set; }

        public ObservableCollection<Filter> CategoryFilters { get; set; }

        public Command ShowFilter { get; }

        public Command ShowSortBy { get; }

        public Command GroupByUnit { get; }

        public Command GroupByAnnouncer { get; }

        public Command FilterToggle { get; }

        public Command ProfileCommand { get; }


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

        private Filter _unit;
        public Filter Unit
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

                FilterToggle.Execute(_unit);

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

            FilterToggle = new Command<String>((_unit) => FilterAnnouncements(_unit));

            ProfileCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage());
            });

        }

        void SetupData()
        {
            _filterVisible = false;
            _sortByVisible = false;

            Announcements = new ObservableRangeCollection<Announcement>();

            AllAnnouncements = new ObservableRangeCollection<Announcement>()
            {
                new Announcement
                {
                    Name = "John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "user1.png",
                    TimePosted = "Tue 11:32am",
                    Category = "Lectures"
                },
                new Announcement
                {
                    Name = "David Webb",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProfileImage = "user2.png",
                    TimePosted = "Tue 8:11am",
                    Category = "Assignments"
                },
                new Announcement
                {
                    Name = "Jane Goodman",
                    Unit = "IAB153",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImage = "user3.png",
                    TimePosted = "Mon 8:44pm",
                    Category = "Exams"
                },
                new Announcement
                {
                    Name = "Josh Grier",
                    Unit = "CAB321",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.",
                    ProfileImage = "user4.png",
                    TimePosted = "Mon 8:29pm",
                    Category = "Assignments"
                },
                new Announcement
                {
                    Name = "Anthony Galletly",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "user5.png",
                    TimePosted = "Fri 12:14pm",
                    Category = "Lectures"
                },
                new Announcement
                {
                    Name = "Lucy Matthews",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ProfileImage = "user6.png",
                    TimePosted = "Fri 8:59am",
                    Category = "Exams"
                },
                new Announcement
                {
                    Name = "Toby Batchler",
                    Unit = "CAB321",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.",
                    ProfileImage = "user7.png",
                    TimePosted = "Thu 9:29pm",
                    Category = "Lectures"
                },
                new Announcement
                {
                    Name = "David Webb",
                    Unit = "CAB123",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImage = "user2.png",
                    TimePosted = "Thu 11:11am",
                    Category = "Assignments"
                }
            };

            string primaryColor = "#03bfff";
            string secondaryColor = "#FFF";

            UnitFilters = new ObservableCollection<Filter>()
            {
                new Filter
                {
                    Name = "CAB202",
                    SelectedIcon = "tick.png",
                    Selected = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new Filter
                {
                    Name = "CAB321",
                    SelectedIcon = "cross.png",
                    Selected = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new Filter
                {
                    Name = "IAB153",
                    SelectedIcon = "tick.png",
                    Selected = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new Filter
                {
                    Name = "CAB123",
                    SelectedIcon = "tick.png",
                    Selected = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                }
            };

            CategoryFilters = new ObservableCollection<Filter>()
            {
                new Filter
                {
                    Name = "Assignments",
                    SelectedIcon = "tick.png",
                    Selected = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new Filter
                {
                    Name = "Lectures",
                    SelectedIcon = "cross.png",
                    Selected = false,
                    BtnColor = primaryColor,
                    TextColor = secondaryColor
                },
                new Filter
                {
                    Name = "Exams",
                    SelectedIcon = "tick.png",
                    Selected = false,
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

        void FilterAnnouncements(String filterParam)
        { 
            if (filterParam != "All")
            {
                foreach (Filter u in UnitFilters)
                {
                    if(filterParam == u.Name)
                    {
                        Announcements.ReplaceRange(AllAnnouncements.Where(a => a.Unit == filterParam));
                    }
                }
                foreach (Filter c in CategoryFilters)
                {
                    if (filterParam == c.Name)
                    {
                        Announcements.ReplaceRange(AllAnnouncements.Where(a => a.Category == filterParam));
                    }
                }
            }
            else
            {
                Announcements.ReplaceRange(AllAnnouncements);
            }
        }
    }
}
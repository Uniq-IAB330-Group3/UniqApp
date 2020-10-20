using Uniq.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Uniq.ViewModels
{
    public class TutorialViewModel : BaseViewModel
    {

        public ObservableCollection<Tutorial> Tutorials { get; set; }

        public TutorialViewModel()
        {
            SetupData();

            Title = "Tutorials";
        }

        void SetupData()
        {
            Tutorials = new ObservableCollection<Tutorial>()
            {
                new Tutorial
                {
                    Head_Title = "Overview",
                    Paragraph = "In todays tutorial we'll be looking at the idstinct adventure"
                    + "of asjkblaj jklasbjk jkag qjjd objsda jodebjod og yeah"


                },

            };
        }
    }
}

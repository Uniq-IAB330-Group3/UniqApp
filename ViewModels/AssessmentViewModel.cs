using Uniq.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Uniq.ViewModels
{
    public class AssessmentViewModel : BaseViewModel
    {
        public ObservableCollection<Assessment> Assessements { get; set; }

        public AssessmentViewModel()
        {
            SetupData();

            Title = "Assessments";
        }

        void SetupData()
        {
            Assessements = new ObservableCollection<Assessment>()
            {
                new Assessment
                {
                    Head_1 = "Assessment 1",
                    Head_2 = "Assessment 1 Brief and CRA",
                    Paragraph = "Proin eget lorem feugiat, rutrum orci et, varius metus. Donec lacinia nunc pellentesque lectus suscipit consectetur facilisis sed an."


                },
                new Assessment
                {
                    Head_1 = "Assessment 2",
                    Head_2 = "Assessment 2 Brief and CRA",
                    Paragraph = "Mauris in feugiat lorem. Mauris consequat ultricies massa, sit amet elementum diam vehicula id. Sed porttitor elementum faucibus. Sed."

                },


            };
        }
    }
}

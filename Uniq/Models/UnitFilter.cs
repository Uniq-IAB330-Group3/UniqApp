using System;
using MvvmHelpers;

namespace Uniq.Models
{
    public class UnitFilter : BaseViewModel
    {
        public string UnitId { get; set; }
        public string SelectedIcon { get; set; }
        public bool Status { get; set; }
        public string TextColor { get; set; }

        //public string BtnColor { get; set; }

        private string _btnColor;
        public string BtnColor
        {
            get { return _btnColor; }
            set
            {
                _btnColor = value;
                OnPropertyChanged(BtnColor);
            }
        }

    }
}
using System;
using MvvmHelpers;

namespace Uniq.Models
{
    public class Filter
    {
        public string Name { get; set; }
        public string SelectedIcon { get; set; }
        public bool Selected { get; set; }
        public string TextColor { get; set; }
        public string BtnColor { get; set; }

    }
}
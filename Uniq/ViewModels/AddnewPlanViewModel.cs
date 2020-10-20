using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Uniq.Models;
using Xamarin.Forms;

namespace Uniq.ViewModels
{
    public class AddnewPlanViewModel : BaseViewModel
    {
        public ICommand ExitCommand { get; }
        private string text;
        private string description;

        public AddnewPlanViewModel()
        {
            ExitCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            //await Shell.Current.GoToAsync("..");
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void OnSave()
        {
            await Application.Current.MainPage.DisplayAlert("Successful", "New Plan was saved", "Ok");
            //Item newItem = new Item()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Text = Text,
            //    Description = Description
            //};

            //await DataStore.AddItemAsync(newItem);

            //// This will pop the current page off the navigation stack
            //await Shell.Current.GoToAsync("..");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Ejercicio3_1.Models;
using Xamarin.Forms;

namespace Ejercicio3_1.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string text;
        private string descripcion;

        public NewItemViewModel()
        {
            AddCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => AddCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(descripcion);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Descripcion
        {
            get => descripcion;
            set => SetProperty(ref descripcion, value);
        }

        public Command AddCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Descripcion = Descripcion
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}

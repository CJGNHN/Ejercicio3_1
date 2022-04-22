using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Ejercicio3_1.Models;

namespace Ejercicio3_1.ViewModels
{
    public class AddEmpleadoViewModel:BaseEmpleadoViewModel
    {
        public Command AddCommand { get; }
        public Command CancelCommand { get; }
        
        public AddEmpleadoViewModel()
        {
            AddCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            this.PropertyChanged +=
                (_, __) => AddCommand.ChangeCanExecute();

            EmpleadoInfo = new EmpleadoInfo();
        }  

        private async void OnSave()
        {
            var empleado = EmpleadoInfo;
            await App.EmpleadoService.AddEmpleadoAsync(empleado);

            await Shell.Current.GoToAsync("..");
        }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}

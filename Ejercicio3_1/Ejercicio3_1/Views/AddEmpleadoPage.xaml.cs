using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicio3_1.Models;
using Ejercicio3_1.ViewModels;

namespace Ejercicio3_1.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmpleadoPage : ContentPage
    {
        public EmpleadoInfo EmpleadoInfo { get; set; }

        public AddEmpleadoPage()
        {
            InitializeComponent();
            BindingContext = new AddEmpleadoViewModel();
        }

        public AddEmpleadoPage(EmpleadoInfo empleadoInfo)
        {
            InitializeComponent();
            BindingContext = new AddEmpleadoViewModel();

            if(empleadoInfo != null)
            {
                ((AddEmpleadoViewModel)BindingContext).EmpleadoInfo = empleadoInfo;
            }
        }
    }
}
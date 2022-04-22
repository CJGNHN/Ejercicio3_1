using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicio3_1.Services;
using Ejercicio3_1.Views;

namespace Ejercicio3_1
{
    public partial class App : Application
    {
        static EmpleadoService _empleadoService;
        public static EmpleadoService EmpleadoService
        {
            get
            {
                if (_empleadoService == null)
                {
                    _empleadoService = new EmpleadoService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleados.db3"));
                }
                return _empleadoService;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

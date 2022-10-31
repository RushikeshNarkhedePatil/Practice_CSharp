using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVM.ViewModel;

namespace WPFMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        { 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            WPFMVVM.View.MainPage window = new View.MainPage();     // create MainPage object
            UserViewModel VM = new UserViewModel();                 // Create user view module object
            window.DataContext = VM;                                // get or set the data
            window.Show();
        }
    }

}

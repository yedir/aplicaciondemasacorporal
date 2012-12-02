using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ControldeMasaMuscular.Movil
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btncalcularmasa_Click(object sender, System.EventArgs e)
        {
        	int calcular = 0;
            NavigationService.Navigate(new Uri("/AdministrarPerfil.xaml?Welcome=" + calcular, UriKind.Relative));
        }

        private void btnperfil_Click(object sender, System.EventArgs e)
        {
        	int menu = 0;
            NavigationService.Navigate(new Uri("/Registros.xaml?Welcome=" + menu, UriKind.Relative));
            
        }
    }
}
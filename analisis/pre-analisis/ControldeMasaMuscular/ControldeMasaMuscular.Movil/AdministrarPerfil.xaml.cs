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
    public partial class AdministrarPerfil : PhoneApplicationPage
    {
        public AdministrarPerfil()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, System.EventArgs e)
        {
        	int perfil = 0;
            NavigationService.Navigate(new Uri("/MainPage.xaml?Welcome=" + perfil, UriKind.Relative));
            MessageBox.Show("Perfil Guardado");
        }
    }
}
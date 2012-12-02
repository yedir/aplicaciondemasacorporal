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
    public partial class Tips : PhoneApplicationPage
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void btnrealizar_Click(object sender, System.EventArgs e)
        {
            int ejercicios = 0;
            NavigationService.Navigate(new Uri("/MainPage.xaml?Welcome=" + ejercicios, UriKind.Relative));
            MessageBox.Show("Buena Suerte");

        }
    }
}
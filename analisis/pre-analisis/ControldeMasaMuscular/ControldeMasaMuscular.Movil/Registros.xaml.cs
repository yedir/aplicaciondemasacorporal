﻿using System;
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
    public partial class Registros : PhoneApplicationPage
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void btncomprobar_Click(object sender, System.EventArgs e)
        {
			int registros = 0;
            NavigationService.Navigate(new Uri("/Tips.xaml?Welcome=" + registros, UriKind.Relative));
            MessageBox.Show("Obeso");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Multi_Login
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        MainWindow handle;

        public Register(MainWindow window)
        {
            InitializeComponent();
            handle = window;
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Check if the left (primary) mouse button was pressed.
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Safely call DragMove only when the left mouse button is pressed.
                this.DragMove();
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            handle.Show();
            this.Close();
        }
    }
}

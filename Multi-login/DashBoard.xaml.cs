using System;
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
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        public DashBoard()
        {
            InitializeComponent();
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

        private void btnAccountlick(object sender, RoutedEventArgs e)
        {
            

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnEscalationP_Click(object sender, RoutedEventArgs e)
        {
            EscalationP escalationP = new EscalationP(this);
            escalationP.Show();
            this.Hide();

        }
        private void btnMenu1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnMenu2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnMenu3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

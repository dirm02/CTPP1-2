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
    /// Interaction logic for EscalationP.xaml
    /// </summary>
    public partial class EscalationP : Window
    {

        bool BusinessImpactTimeState = false;

        DashBoard handle;
        public EscalationP(DashBoard handle)
        {
            InitializeComponent();
            this.handle = handle;

            btnImpact.IsEnabled = false;
            btnTotal.IsEnabled = false;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnResolve_Click(object sender, RoutedEventArgs e)
        {
            BusinessImpactTimeState = !BusinessImpactTimeState;
            btnImpact.IsEnabled = BusinessImpactTimeState;

            btnTotal.IsEnabled = BusinessImpactTimeState;
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
            handle.Show();
            this.Close();
        }
    }
}

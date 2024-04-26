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
using System.IO;

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
            txtSiteNumber.Text = "";
            txtLocation.Text = "";
            txtSiteContact.Text = "";
            txtHourSite.SelectedIndex = 0;
            txtNumberofPayPoints.SelectedIndex = 0;
            txtIncidentDescription.SelectedIndex = 0;
            txtBusinessImpact.Text = "";
            txtCurrentStatus.Text = "";
            txtReferenceNumber.Text = "";
            txtTechnicianAssigned.Text = "";
            txtSecondLevelAssigned.Text = "";
            txtChonology.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "file.txt";

            string siteNumber = txtSiteNumber.Text;
            string location = txtLocation.Text;
            string siteContact = txtSiteContact.Text;
            string hourSite = "Yes";
            if (txtHourSite.SelectedIndex == 1)
                hourSite = "No";

            string numberOfPayPoints = (txtNumberofPayPoints.SelectedIndex + 1) + "";
            string incidentDescription = (txtIncidentDescription.SelectedIndex + 'A') + "";
            string businessImpact = txtBusinessImpact.Text;
            string currentStatus = txtCurrentStatus.Text;
            string referenceNumber = txtReferenceNumber.Text;
            string technicianAssigned = txtTechnicianAssigned.Text;
            string secondLevelAssigned = txtSecondLevelAssigned.Text;
            string chronology = txtChonology.Text;

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Site Number: \t\t" + siteNumber);
                    writer.WriteLine("Location: \t\t" + location);
                    writer.WriteLine("Site Contact: \t\t" + siteContact);
                    writer.WriteLine("Hour Site: \t\t" + hourSite);
                    writer.WriteLine("Number of Pay Points: \t\t" + numberOfPayPoints);
                    writer.WriteLine("Incident Description: \t\t" + incidentDescription);
                    writer.WriteLine("Business Impact: \t\t" + businessImpact);
                    writer.WriteLine("Current Status: \t\t" + currentStatus);
                    writer.WriteLine("Reference Number: \t\t" + referenceNumber);
                    writer.WriteLine("Technician Assigned: \t\t" + technicianAssigned);
                    writer.WriteLine("Second Level Assigned: \t\t" + secondLevelAssigned);
                    writer.WriteLine("Chronology: \t\t" + chronology);
                    writer.Close();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing file: " + ex.Message);
            }
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

using Entities.Models;
using Repository;
using Service;
using Service.Contracts;

namespace FleetPandaAssessment
{
    public partial class MainForm : Form
    {
        private readonly ISyncService syncService;
        private IEnumerable<Customer> customers = new List<Customer>();
        public MainForm()
        {
            InitializeComponent();
            syncService = new SyncService();
            customersDataGridView.AutoGenerateColumns = false;
            customerName.DataPropertyName = "Name";
            customerEmail.DataPropertyName = "Email";
            customerPhone.DataPropertyName = "Phone";
            customerLocations.DataPropertyName = "LocationNames";
            GetCustomersFromLocal();
        }

        private async void GetCustomersFromLocal()
        {
            try
            {
                customers = await syncService.GetCustomersWithLocationFromLocal();
                
                customersDataGridView.DataSource = customers;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void refreshDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                await syncService.SyncData();
                GetCustomersFromLocal();
                MessageBox.Show("Data Synced Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setIntervalButton_Click(object sender, EventArgs e)
        {
            var interSetupPage = new ManageInterval(timer1);
            interSetupPage.ShowDialog(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Dispose();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                await syncService.SyncData();
                GetCustomersFromLocal();
            }catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

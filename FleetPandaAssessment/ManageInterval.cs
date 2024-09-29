namespace FleetPandaAssessment
{
    public partial class ManageInterval : Form
    {
        private System.Windows.Forms.Timer _timer;
        public ManageInterval(System.Windows.Forms.Timer timer)
        {
            InitializeComponent();
            _timer = timer;
        }

        private void setIntervalButton_Click(object sender, EventArgs e)
        {
            var selectedHour = hourComboBox.SelectedItem;
            var selectedMinute = minuteComboBox.SelectedItem;
            var selectedSecond = secondComboBox.SelectedItem;
            if(selectedHour is null || selectedMinute is null || selectedSecond is null)
            {
                MessageBox.Show("Please selected Hour, Minute & Second", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                var hours = Convert.ToInt32(selectedHour);
                var minutes = Convert.ToInt32(selectedMinute);
                var seconds = Convert.ToInt32(selectedSecond);

                var totalSeconds = hours * 60 * 60 + minutes * 60 + seconds;
                var timerValue = totalSeconds * 1000; // in milliseconds

                _timer.Interval = timerValue;
                _timer.Start();

                this.Close();
            }
        }
    }
}

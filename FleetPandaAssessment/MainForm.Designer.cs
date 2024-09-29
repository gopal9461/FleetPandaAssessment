namespace FleetPandaAssessment
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            setIntervalButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            refreshDataButton = new Button();
            customersDataGridView = new DataGridView();
            customerName = new DataGridViewTextBoxColumn();
            customerEmail = new DataGridViewTextBoxColumn();
            customerPhone = new DataGridViewTextBoxColumn();
            customerLocations = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // setIntervalButton
            // 
            setIntervalButton.BackColor = Color.Lime;
            setIntervalButton.Dock = DockStyle.Fill;
            setIntervalButton.Location = new Point(2, 2);
            setIntervalButton.Margin = new Padding(2);
            setIntervalButton.Name = "setIntervalButton";
            setIntervalButton.Size = new Size(464, 31);
            setIntervalButton.TabIndex = 1;
            setIntervalButton.Text = "Set Interval";
            setIntervalButton.UseVisualStyleBackColor = false;
            setIntervalButton.Click += setIntervalButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(setIntervalButton, 0, 0);
            tableLayoutPanel1.Controls.Add(refreshDataButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(937, 35);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // refreshDataButton
            // 
            refreshDataButton.BackColor = Color.Blue;
            refreshDataButton.Dock = DockStyle.Fill;
            refreshDataButton.ForeColor = Color.White;
            refreshDataButton.Location = new Point(470, 2);
            refreshDataButton.Margin = new Padding(2);
            refreshDataButton.Name = "refreshDataButton";
            refreshDataButton.Size = new Size(465, 31);
            refreshDataButton.TabIndex = 2;
            refreshDataButton.Text = "Refresh";
            refreshDataButton.UseVisualStyleBackColor = false;
            refreshDataButton.Click += refreshDataButton_Click;
            // 
            // customersDataGridView
            // 
            customersDataGridView.AllowUserToAddRows = false;
            customersDataGridView.AllowUserToDeleteRows = false;
            customersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            customersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Columns.AddRange(new DataGridViewColumn[] { customerName, customerEmail, customerPhone, customerLocations });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customersDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            customersDataGridView.Dock = DockStyle.Fill;
            customersDataGridView.Location = new Point(0, 35);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.ReadOnly = true;
            customersDataGridView.Size = new Size(937, 363);
            customersDataGridView.TabIndex = 3;
            // 
            // customerName
            // 
            customerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerName.HeaderText = "Name";
            customerName.Name = "customerName";
            customerName.ReadOnly = true;
            // 
            // customerEmail
            // 
            customerEmail.HeaderText = "Email";
            customerEmail.Name = "customerEmail";
            customerEmail.ReadOnly = true;
            customerEmail.Width = 61;
            // 
            // customerPhone
            // 
            customerPhone.HeaderText = "Phone";
            customerPhone.Name = "customerPhone";
            customerPhone.ReadOnly = true;
            customerPhone.Width = 66;
            // 
            // customerLocations
            // 
            customerLocations.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerLocations.HeaderText = "Locations";
            customerLocations.Name = "customerLocations";
            customerLocations.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 398);
            Controls.Add(customersDataGridView);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Customers";
            FormClosing += MainForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button setIntervalButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button refreshDataButton;
        private DataGridView customersDataGridView;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn customerEmail;
        private DataGridViewTextBoxColumn customerPhone;
        private DataGridViewTextBoxColumn customerLocations;
    }
}

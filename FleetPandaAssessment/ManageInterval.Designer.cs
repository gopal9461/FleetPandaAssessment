namespace FleetPandaAssessment
{
    partial class ManageInterval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hourLabel = new Label();
            hourComboBox = new ComboBox();
            minuteComboBox = new ComboBox();
            minuteLabel = new Label();
            secondComboBox = new ComboBox();
            secondLabel = new Label();
            setIntervalButton = new Button();
            SuspendLayout();
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Location = new Point(12, 9);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new Size(34, 15);
            hourLabel.TabIndex = 0;
            hourLabel.Text = "Hour";
            // 
            // hourComboBox
            // 
            hourComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hourComboBox.FlatStyle = FlatStyle.Flat;
            hourComboBox.FormattingEnabled = true;
            hourComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            hourComboBox.Location = new Point(56, 6);
            hourComboBox.Name = "hourComboBox";
            hourComboBox.Size = new Size(69, 23);
            hourComboBox.TabIndex = 1;
            // 
            // minuteComboBox
            // 
            minuteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            minuteComboBox.FlatStyle = FlatStyle.Flat;
            minuteComboBox.FormattingEnabled = true;
            minuteComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            minuteComboBox.Location = new Point(212, 6);
            minuteComboBox.Name = "minuteComboBox";
            minuteComboBox.Size = new Size(69, 23);
            minuteComboBox.TabIndex = 3;
            // 
            // minuteLabel
            // 
            minuteLabel.AutoSize = true;
            minuteLabel.Location = new Point(157, 9);
            minuteLabel.Name = "minuteLabel";
            minuteLabel.Size = new Size(45, 15);
            minuteLabel.TabIndex = 2;
            minuteLabel.Text = "Minute";
            // 
            // secondComboBox
            // 
            secondComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            secondComboBox.FlatStyle = FlatStyle.Flat;
            secondComboBox.FormattingEnabled = true;
            secondComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            secondComboBox.Location = new Point(367, 6);
            secondComboBox.Name = "secondComboBox";
            secondComboBox.Size = new Size(69, 23);
            secondComboBox.TabIndex = 5;
            // 
            // secondLabel
            // 
            secondLabel.AutoSize = true;
            secondLabel.Location = new Point(319, 9);
            secondLabel.Name = "secondLabel";
            secondLabel.Size = new Size(46, 15);
            secondLabel.TabIndex = 4;
            secondLabel.Text = "Second";
            // 
            // setIntervalButton
            // 
            setIntervalButton.BackColor = Color.Lime;
            setIntervalButton.Location = new Point(467, 5);
            setIntervalButton.Name = "setIntervalButton";
            setIntervalButton.Size = new Size(126, 23);
            setIntervalButton.TabIndex = 6;
            setIntervalButton.Text = "Set";
            setIntervalButton.UseVisualStyleBackColor = false;
            setIntervalButton.Click += setIntervalButton_Click;
            // 
            // ManageInterval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 83);
            Controls.Add(setIntervalButton);
            Controls.Add(secondComboBox);
            Controls.Add(secondLabel);
            Controls.Add(minuteComboBox);
            Controls.Add(minuteLabel);
            Controls.Add(hourComboBox);
            Controls.Add(hourLabel);
            Name = "ManageInterval";
            Text = "Set Interval";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hourLabel;
        private ComboBox hourComboBox;
        private ComboBox minuteComboBox;
        private Label minuteLabel;
        private ComboBox secondComboBox;
        private Label secondLabel;
        private Button setIntervalButton;
    }
}
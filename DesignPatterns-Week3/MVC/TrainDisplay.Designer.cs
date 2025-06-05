namespace MVC
{
    partial class TrainDisplay
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
            this.currentStation = new System.Windows.Forms.Label();
            this.displayCurrentStation = new System.Windows.Forms.Label();
            this.spoor = new System.Windows.Forms.Label();
            this.displaySpoor = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.Label();
            this.displayArrivalTime = new System.Windows.Forms.Label();
            this.departureTime = new System.Windows.Forms.Label();
            this.displayDepartureTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentStation
            // 
            this.currentStation.AutoSize = true;
            this.currentStation.Location = new System.Drawing.Point(21, 29);
            this.currentStation.Name = "currentStation";
            this.currentStation.Size = new System.Drawing.Size(80, 13);
            this.currentStation.TabIndex = 0;
            this.currentStation.Text = "Current Station:";
            this.currentStation.Click += new System.EventHandler(this.currentStation_Click);
            // 
            // displayCurrentStation
            // 
            this.displayCurrentStation.AutoSize = true;
            this.displayCurrentStation.Location = new System.Drawing.Point(159, 29);
            this.displayCurrentStation.Name = "displayCurrentStation";
            this.displayCurrentStation.Size = new System.Drawing.Size(19, 13);
            this.displayCurrentStation.TabIndex = 1;
            this.displayCurrentStation.Text = "....";
            this.displayCurrentStation.Click += new System.EventHandler(this.displayCurrentStation_Click);
            // 
            // spoor
            // 
            this.spoor.AutoSize = true;
            this.spoor.Location = new System.Drawing.Point(21, 59);
            this.spoor.Name = "spoor";
            this.spoor.Size = new System.Drawing.Size(38, 13);
            this.spoor.TabIndex = 2;
            this.spoor.Text = "Track:";
            this.spoor.Click += new System.EventHandler(this.spoor_Click);
            // 
            // displaySpoor
            // 
            this.displaySpoor.AutoSize = true;
            this.displaySpoor.Location = new System.Drawing.Point(159, 59);
            this.displaySpoor.Name = "displaySpoor";
            this.displaySpoor.Size = new System.Drawing.Size(19, 13);
            this.displaySpoor.TabIndex = 3;
            this.displaySpoor.Text = "....";
            // 
            // arrivalTime
            // 
            this.arrivalTime.AutoSize = true;
            this.arrivalTime.Location = new System.Drawing.Point(21, 90);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(65, 13);
            this.arrivalTime.TabIndex = 4;
            this.arrivalTime.Text = "Arrival Time:";
            this.arrivalTime.Click += new System.EventHandler(this.arrivalTime_Click);
            // 
            // displayArrivalTime
            // 
            this.displayArrivalTime.AutoSize = true;
            this.displayArrivalTime.Location = new System.Drawing.Point(159, 90);
            this.displayArrivalTime.Name = "displayArrivalTime";
            this.displayArrivalTime.Size = new System.Drawing.Size(19, 13);
            this.displayArrivalTime.TabIndex = 5;
            this.displayArrivalTime.Text = "....";
            // 
            // departureTime
            // 
            this.departureTime.AutoSize = true;
            this.departureTime.Location = new System.Drawing.Point(21, 124);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(83, 13);
            this.departureTime.TabIndex = 6;
            this.departureTime.Text = "Departure Time:";
            // 
            // displayDepartureTime
            // 
            this.displayDepartureTime.AutoSize = true;
            this.displayDepartureTime.Location = new System.Drawing.Point(159, 124);
            this.displayDepartureTime.Name = "displayDepartureTime";
            this.displayDepartureTime.Size = new System.Drawing.Size(19, 13);
            this.displayDepartureTime.TabIndex = 7;
            this.displayDepartureTime.Text = "....";
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 169);
            this.Controls.Add(this.displayDepartureTime);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.displayArrivalTime);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.displaySpoor);
            this.Controls.Add(this.spoor);
            this.Controls.Add(this.displayCurrentStation);
            this.Controls.Add(this.currentStation);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.Load += new System.EventHandler(this.StationDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentStation;
        private System.Windows.Forms.Label displayCurrentStation;
        private System.Windows.Forms.Label spoor;
        private System.Windows.Forms.Label displaySpoor;
        private System.Windows.Forms.Label arrivalTime;
        private System.Windows.Forms.Label displayArrivalTime;
        private System.Windows.Forms.Label departureTime;
        private System.Windows.Forms.Label displayDepartureTime;
    }
}
namespace MVC
{
    partial class ControlPanel
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
            this.nextStation = new System.Windows.Forms.Button();
            this.newDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextStation
            // 
            this.nextStation.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.nextStation.FlatAppearance.BorderSize = 15;
            this.nextStation.Location = new System.Drawing.Point(32, 30);
            this.nextStation.Name = "nextStation";
            this.nextStation.Size = new System.Drawing.Size(127, 39);
            this.nextStation.TabIndex = 0;
            this.nextStation.Text = "Next Station";
            this.nextStation.UseVisualStyleBackColor = true;
            this.nextStation.Click += new System.EventHandler(this.nextStation_Click);
            // 
            // newDisplay
            // 
            this.newDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.newDisplay.FlatAppearance.BorderSize = 15;
            this.newDisplay.Location = new System.Drawing.Point(196, 30);
            this.newDisplay.Name = "newDisplay";
            this.newDisplay.Size = new System.Drawing.Size(127, 39);
            this.newDisplay.TabIndex = 1;
            this.newDisplay.Text = "New Display";
            this.newDisplay.UseVisualStyleBackColor = true;
            this.newDisplay.Click += new System.EventHandler(this.newDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 98);
            this.Controls.Add(this.newDisplay);
            this.Controls.Add(this.nextStation);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextStation;
        private System.Windows.Forms.Button newDisplay;
    }
}


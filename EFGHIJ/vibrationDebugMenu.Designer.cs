namespace EFGHIJ
{
    partial class vibrationDebugMenu
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
            this.OffButton = new System.Windows.Forms.Button();
            this.QuarterPercent = new System.Windows.Forms.Button();
            this.FiftyPercent = new System.Windows.Forms.Button();
            this.ThreeQuarterPercent = new System.Windows.Forms.Button();
            this.MaxPercent = new System.Windows.Forms.Button();
            this.vibrationTrackBar = new System.Windows.Forms.TrackBar();
            this.vibrationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vibrationTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(55, 50);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(75, 23);
            this.OffButton.TabIndex = 0;
            this.OffButton.Text = "Turn Off";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // QuarterPercent
            // 
            this.QuarterPercent.Location = new System.Drawing.Point(200, 50);
            this.QuarterPercent.Name = "QuarterPercent";
            this.QuarterPercent.Size = new System.Drawing.Size(75, 23);
            this.QuarterPercent.TabIndex = 1;
            this.QuarterPercent.Text = "25%";
            this.QuarterPercent.UseVisualStyleBackColor = true;
            this.QuarterPercent.Click += new System.EventHandler(this.QuarterPercent_Click);
            // 
            // FiftyPercent
            // 
            this.FiftyPercent.Location = new System.Drawing.Point(351, 50);
            this.FiftyPercent.Name = "FiftyPercent";
            this.FiftyPercent.Size = new System.Drawing.Size(75, 23);
            this.FiftyPercent.TabIndex = 2;
            this.FiftyPercent.Text = "50%";
            this.FiftyPercent.UseVisualStyleBackColor = true;
            this.FiftyPercent.Click += new System.EventHandler(this.FiftyPercent_Click);
            // 
            // ThreeQuarterPercent
            // 
            this.ThreeQuarterPercent.Location = new System.Drawing.Point(510, 50);
            this.ThreeQuarterPercent.Name = "ThreeQuarterPercent";
            this.ThreeQuarterPercent.Size = new System.Drawing.Size(75, 23);
            this.ThreeQuarterPercent.TabIndex = 3;
            this.ThreeQuarterPercent.Text = "75%";
            this.ThreeQuarterPercent.UseVisualStyleBackColor = true;
            this.ThreeQuarterPercent.Click += new System.EventHandler(this.ThreeQuarterPercent_Click);
            // 
            // MaxPercent
            // 
            this.MaxPercent.Location = new System.Drawing.Point(665, 50);
            this.MaxPercent.Name = "MaxPercent";
            this.MaxPercent.Size = new System.Drawing.Size(75, 23);
            this.MaxPercent.TabIndex = 4;
            this.MaxPercent.Text = "100%";
            this.MaxPercent.UseVisualStyleBackColor = true;
            this.MaxPercent.Click += new System.EventHandler(this.MaxPercent_Click);
            // 
            // vibrationTrackBar
            // 
            this.vibrationTrackBar.Location = new System.Drawing.Point(111, 204);
            this.vibrationTrackBar.Maximum = 100;
            this.vibrationTrackBar.Name = "vibrationTrackBar";
            this.vibrationTrackBar.Size = new System.Drawing.Size(561, 45);
            this.vibrationTrackBar.TabIndex = 5;
            this.vibrationTrackBar.TickFrequency = 10;
            this.vibrationTrackBar.Scroll += new System.EventHandler(this.vibrationTrackBar_Scroll);
            // 
            // vibrationLabel
            // 
            this.vibrationLabel.AutoSize = true;
            this.vibrationLabel.Location = new System.Drawing.Point(386, 188);
            this.vibrationLabel.Name = "vibrationLabel";
            this.vibrationLabel.Size = new System.Drawing.Size(13, 13);
            this.vibrationLabel.TabIndex = 6;
            this.vibrationLabel.Text = "0";
            // 
            // vibrationDebugMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vibrationLabel);
            this.Controls.Add(this.vibrationTrackBar);
            this.Controls.Add(this.MaxPercent);
            this.Controls.Add(this.ThreeQuarterPercent);
            this.Controls.Add(this.FiftyPercent);
            this.Controls.Add(this.QuarterPercent);
            this.Controls.Add(this.OffButton);
            this.Name = "vibrationDebugMenu";
            this.Text = "Vibration Debug Menu";
            ((System.ComponentModel.ISupportInitialize)(this.vibrationTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OffButton;
        private System.Windows.Forms.Button QuarterPercent;
        private System.Windows.Forms.Button FiftyPercent;
        private System.Windows.Forms.Button ThreeQuarterPercent;
        private System.Windows.Forms.Button MaxPercent;
        private System.Windows.Forms.TrackBar vibrationTrackBar;
        private System.Windows.Forms.Label vibrationLabel;
    }
}


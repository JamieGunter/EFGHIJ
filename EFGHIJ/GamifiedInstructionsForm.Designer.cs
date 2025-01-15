namespace EFGHIJ
{
    partial class GamifiedInstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamifiedInstructionsForm));
            this.taskInitiatorGridBox = new System.Windows.Forms.GroupBox();
            this.GamifiedSubheadingLabel = new System.Windows.Forms.Label();
            this.GamifiedTitleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.beginTaskButton = new System.Windows.Forms.Button();
            this.taskInitiatorGridBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskInitiatorGridBox
            // 
            this.taskInitiatorGridBox.Controls.Add(this.GamifiedSubheadingLabel);
            this.taskInitiatorGridBox.Controls.Add(this.GamifiedTitleLabel);
            this.taskInitiatorGridBox.Controls.Add(this.instructionLabel);
            this.taskInitiatorGridBox.Controls.Add(this.beginTaskButton);
            this.taskInitiatorGridBox.Location = new System.Drawing.Point(-1, -3);
            this.taskInitiatorGridBox.Name = "taskInitiatorGridBox";
            this.taskInitiatorGridBox.Size = new System.Drawing.Size(802, 457);
            this.taskInitiatorGridBox.TabIndex = 7;
            this.taskInitiatorGridBox.TabStop = false;
            // 
            // GamifiedSubheadingLabel
            // 
            this.GamifiedSubheadingLabel.AutoSize = true;
            this.GamifiedSubheadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamifiedSubheadingLabel.Location = new System.Drawing.Point(108, 45);
            this.GamifiedSubheadingLabel.Name = "GamifiedSubheadingLabel";
            this.GamifiedSubheadingLabel.Size = new System.Drawing.Size(587, 40);
            this.GamifiedSubheadingLabel.TabIndex = 3;
            this.GamifiedSubheadingLabel.Text = "Using either the Directional Pad (DPad) on the left side of the controller,\r\nor t" +
    "he mouse to click the buttons, please perform the following task:";
            this.GamifiedSubheadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamifiedTitleLabel
            // 
            this.GamifiedTitleLabel.AutoSize = true;
            this.GamifiedTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.GamifiedTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GamifiedTitleLabel.Location = new System.Drawing.Point(189, 9);
            this.GamifiedTitleLabel.Name = "GamifiedTitleLabel";
            this.GamifiedTitleLabel.Size = new System.Drawing.Size(425, 29);
            this.GamifiedTitleLabel.TabIndex = 2;
            this.GamifiedTitleLabel.Text = "Welcome to the Lock Picking Game";
            this.GamifiedTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.instructionLabel.Location = new System.Drawing.Point(83, 93);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(637, 280);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = resources.GetString("instructionLabel.Text");
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginTaskButton
            // 
            this.beginTaskButton.Location = new System.Drawing.Point(295, 379);
            this.beginTaskButton.Name = "beginTaskButton";
            this.beginTaskButton.Size = new System.Drawing.Size(212, 67);
            this.beginTaskButton.TabIndex = 0;
            this.beginTaskButton.Text = "Begin";
            this.beginTaskButton.UseVisualStyleBackColor = true;
            this.beginTaskButton.Click += new System.EventHandler(this.beginTaskButton_Click);
            // 
            // GamifiedInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskInitiatorGridBox);
            this.Name = "GamifiedInstructionsForm";
            this.Text = "GamifiedInstructionsForm";
            this.taskInitiatorGridBox.ResumeLayout(false);
            this.taskInitiatorGridBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox taskInitiatorGridBox;
        private System.Windows.Forms.Label GamifiedSubheadingLabel;
        private System.Windows.Forms.Label GamifiedTitleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button beginTaskButton;
    }
}
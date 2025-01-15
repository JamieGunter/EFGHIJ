namespace EFGHIJ
{
    partial class VanillaInstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VanillaInstructionsForm));
            this.VanillaSubheadingLabel = new System.Windows.Forms.Label();
            this.VanillaTitleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.beginTaskButton = new System.Windows.Forms.Button();
            this.taskInitiatorGridBox = new System.Windows.Forms.GroupBox();
            this.taskInitiatorGridBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VanillaSubheadingLabel
            // 
            this.VanillaSubheadingLabel.AutoSize = true;
            this.VanillaSubheadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanillaSubheadingLabel.Location = new System.Drawing.Point(108, 45);
            this.VanillaSubheadingLabel.Name = "VanillaSubheadingLabel";
            this.VanillaSubheadingLabel.Size = new System.Drawing.Size(587, 40);
            this.VanillaSubheadingLabel.TabIndex = 3;
            this.VanillaSubheadingLabel.Text = "Using either the Directional Pad (DPad) on the left side of the controller,\r\nor t" +
    "he mouse to click the buttons, please perform the following task:";
            this.VanillaSubheadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VanillaTitleLabel
            // 
            this.VanillaTitleLabel.AutoSize = true;
            this.VanillaTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.VanillaTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VanillaTitleLabel.Location = new System.Drawing.Point(97, 9);
            this.VanillaTitleLabel.Name = "VanillaTitleLabel";
            this.VanillaTitleLabel.Size = new System.Drawing.Size(609, 29);
            this.VanillaTitleLabel.TabIndex = 2;
            this.VanillaTitleLabel.Text = "Welcome to the Vanilla Interface of this experiment.";
            this.VanillaTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // taskInitiatorGridBox
            // 
            this.taskInitiatorGridBox.Controls.Add(this.VanillaSubheadingLabel);
            this.taskInitiatorGridBox.Controls.Add(this.VanillaTitleLabel);
            this.taskInitiatorGridBox.Controls.Add(this.instructionLabel);
            this.taskInitiatorGridBox.Controls.Add(this.beginTaskButton);
            this.taskInitiatorGridBox.Location = new System.Drawing.Point(-1, -3);
            this.taskInitiatorGridBox.Name = "taskInitiatorGridBox";
            this.taskInitiatorGridBox.Size = new System.Drawing.Size(802, 457);
            this.taskInitiatorGridBox.TabIndex = 6;
            this.taskInitiatorGridBox.TabStop = false;
            // 
            // VanillaInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskInitiatorGridBox);
            this.Name = "VanillaInstructionsForm";
            this.Text = "VanillaInstructionsForm";
            this.taskInitiatorGridBox.ResumeLayout(false);
            this.taskInitiatorGridBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VanillaSubheadingLabel;
        private System.Windows.Forms.Label VanillaTitleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button beginTaskButton;
        private System.Windows.Forms.GroupBox taskInitiatorGridBox;
    }
}
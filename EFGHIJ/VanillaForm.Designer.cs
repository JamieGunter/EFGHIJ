namespace EFGHIJ
{
    partial class VanillaForm
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
            this.getOriginalStimuliButton = new System.Windows.Forms.Button();
            this.getNewStimuliButton = new System.Windows.Forms.Button();
            this.V2IsLowerButton = new System.Windows.Forms.Button();
            this.V2IsNotLower = new System.Windows.Forms.Button();
            this.trialNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getOriginalStimuliButton
            // 
            this.getOriginalStimuliButton.Location = new System.Drawing.Point(639, 12);
            this.getOriginalStimuliButton.Name = "getOriginalStimuliButton";
            this.getOriginalStimuliButton.Size = new System.Drawing.Size(149, 63);
            this.getOriginalStimuliButton.TabIndex = 0;
            this.getOriginalStimuliButton.Text = "Get Original Stimuli Reference";
            this.getOriginalStimuliButton.UseVisualStyleBackColor = true;
            this.getOriginalStimuliButton.Click += new System.EventHandler(this.getOriginalStimuliButton_Click);
            // 
            // getNewStimuliButton
            // 
            this.getNewStimuliButton.Location = new System.Drawing.Point(639, 96);
            this.getNewStimuliButton.Name = "getNewStimuliButton";
            this.getNewStimuliButton.Size = new System.Drawing.Size(149, 63);
            this.getNewStimuliButton.TabIndex = 1;
            this.getNewStimuliButton.Text = "Get New Stimuli Reference";
            this.getNewStimuliButton.UseVisualStyleBackColor = true;
            this.getNewStimuliButton.Click += new System.EventHandler(this.getNewStimuliButton_Click);
            // 
            // V2IsLowerButton
            // 
            this.V2IsLowerButton.Location = new System.Drawing.Point(216, 185);
            this.V2IsLowerButton.Name = "V2IsLowerButton";
            this.V2IsLowerButton.Size = new System.Drawing.Size(149, 63);
            this.V2IsLowerButton.TabIndex = 2;
            this.V2IsLowerButton.Text = "New Stimuli Is Lower Intensity";
            this.V2IsLowerButton.UseVisualStyleBackColor = true;
            this.V2IsLowerButton.Click += new System.EventHandler(this.V2IsLowerButton_Click);
            // 
            // V2IsNotLower
            // 
            this.V2IsNotLower.Location = new System.Drawing.Point(407, 185);
            this.V2IsNotLower.Name = "V2IsNotLower";
            this.V2IsNotLower.Size = new System.Drawing.Size(149, 63);
            this.V2IsNotLower.TabIndex = 3;
            this.V2IsNotLower.Text = "New Stimuli Is Higher Intensity";
            this.V2IsNotLower.UseVisualStyleBackColor = true;
            this.V2IsNotLower.Click += new System.EventHandler(this.V2IsNotLower_Click);
            // 
            // trialNumberLabel
            // 
            this.trialNumberLabel.AutoSize = true;
            this.trialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.trialNumberLabel.Location = new System.Drawing.Point(365, 127);
            this.trialNumberLabel.Name = "trialNumberLabel";
            this.trialNumberLabel.Size = new System.Drawing.Size(42, 46);
            this.trialNumberLabel.TabIndex = 4;
            this.trialNumberLabel.Text = "1";
            this.trialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VanillaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trialNumberLabel);
            this.Controls.Add(this.V2IsNotLower);
            this.Controls.Add(this.V2IsLowerButton);
            this.Controls.Add(this.getNewStimuliButton);
            this.Controls.Add(this.getOriginalStimuliButton);
            this.Name = "VanillaForm";
            this.Text = "Vanilla Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getOriginalStimuliButton;
        private System.Windows.Forms.Button getNewStimuliButton;
        private System.Windows.Forms.Button V2IsLowerButton;
        private System.Windows.Forms.Button V2IsNotLower;
        private System.Windows.Forms.Label trialNumberLabel;
    }
}
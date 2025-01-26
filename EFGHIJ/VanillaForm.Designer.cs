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
            this.V2IsNotLowerButton = new System.Windows.Forms.Button();
            this.trialNumberLabel = new System.Windows.Forms.Label();
            this.VanillaTaskNumberTitle = new System.Windows.Forms.Label();
            this.VanillaRightDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.VanillaLeftDpadGlyphImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaRightDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaLeftDpadGlyphImage)).BeginInit();
            this.SuspendLayout();
            // 
            // getOriginalStimuliButton
            // 
            this.getOriginalStimuliButton.Location = new System.Drawing.Point(639, 12);
            this.getOriginalStimuliButton.Name = "getOriginalStimuliButton";
            this.getOriginalStimuliButton.Size = new System.Drawing.Size(149, 63);
            this.getOriginalStimuliButton.TabIndex = 0;
            this.getOriginalStimuliButton.Text = "Original Stimuli (V1)";
            this.getOriginalStimuliButton.UseVisualStyleBackColor = true;
            this.getOriginalStimuliButton.Click += new System.EventHandler(this.getOriginalStimuliButton_Click);
            // 
            // getNewStimuliButton
            // 
            this.getNewStimuliButton.Location = new System.Drawing.Point(639, 81);
            this.getNewStimuliButton.Name = "getNewStimuliButton";
            this.getNewStimuliButton.Size = new System.Drawing.Size(149, 63);
            this.getNewStimuliButton.TabIndex = 1;
            this.getNewStimuliButton.Text = "New Stimuli (V2)";
            this.getNewStimuliButton.UseVisualStyleBackColor = true;
            this.getNewStimuliButton.Click += new System.EventHandler(this.getNewStimuliButton_Click);
            // 
            // V2IsLowerButton
            // 
            this.V2IsLowerButton.Location = new System.Drawing.Point(226, 194);
            this.V2IsLowerButton.Name = "V2IsLowerButton";
            this.V2IsLowerButton.Size = new System.Drawing.Size(149, 63);
            this.V2IsLowerButton.TabIndex = 2;
            this.V2IsLowerButton.Text = "New Stimuli Is Lower Intensity";
            this.V2IsLowerButton.UseVisualStyleBackColor = true;
            this.V2IsLowerButton.Click += new System.EventHandler(this.V2IsLowerButton_Click);
            // 
            // V2IsNotLowerButton
            // 
            this.V2IsNotLowerButton.Location = new System.Drawing.Point(426, 194);
            this.V2IsNotLowerButton.Name = "V2IsNotLowerButton";
            this.V2IsNotLowerButton.Size = new System.Drawing.Size(149, 63);
            this.V2IsNotLowerButton.TabIndex = 3;
            this.V2IsNotLowerButton.Text = "New Stimuli Is Higher Intensity";
            this.V2IsNotLowerButton.UseVisualStyleBackColor = true;
            this.V2IsNotLowerButton.Click += new System.EventHandler(this.V2IsNotLowerButton_Click);
            // 
            // trialNumberLabel
            // 
            this.trialNumberLabel.AutoSize = true;
            this.trialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.trialNumberLabel.Location = new System.Drawing.Point(379, 127);
            this.trialNumberLabel.Name = "trialNumberLabel";
            this.trialNumberLabel.Size = new System.Drawing.Size(42, 46);
            this.trialNumberLabel.TabIndex = 4;
            this.trialNumberLabel.Text = "1";
            this.trialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VanillaTaskNumberTitle
            // 
            this.VanillaTaskNumberTitle.AutoSize = true;
            this.VanillaTaskNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanillaTaskNumberTitle.Location = new System.Drawing.Point(343, 101);
            this.VanillaTaskNumberTitle.Name = "VanillaTaskNumberTitle";
            this.VanillaTaskNumberTitle.Size = new System.Drawing.Size(114, 20);
            this.VanillaTaskNumberTitle.TabIndex = 6;
            this.VanillaTaskNumberTitle.Text = "Task Number";
            this.VanillaTaskNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VanillaRightDpadGlyphImage
            // 
            this.VanillaRightDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaRightDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.RightGlyphDPadGlyphMap;
            this.VanillaRightDpadGlyphImage.Location = new System.Drawing.Point(581, 194);
            this.VanillaRightDpadGlyphImage.Name = "VanillaRightDpadGlyphImage";
            this.VanillaRightDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaRightDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaRightDpadGlyphImage.TabIndex = 10;
            this.VanillaRightDpadGlyphImage.TabStop = false;
            // 
            // VanillaLeftDpadGlyphImage
            // 
            this.VanillaLeftDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaLeftDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.LeftGlyphDPadGlyphMap;
            this.VanillaLeftDpadGlyphImage.Location = new System.Drawing.Point(157, 194);
            this.VanillaLeftDpadGlyphImage.Name = "VanillaLeftDpadGlyphImage";
            this.VanillaLeftDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaLeftDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaLeftDpadGlyphImage.TabIndex = 9;
            this.VanillaLeftDpadGlyphImage.TabStop = false;
            // 
            // VanillaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VanillaRightDpadGlyphImage);
            this.Controls.Add(this.VanillaLeftDpadGlyphImage);
            this.Controls.Add(this.VanillaTaskNumberTitle);
            this.Controls.Add(this.trialNumberLabel);
            this.Controls.Add(this.V2IsNotLowerButton);
            this.Controls.Add(this.V2IsLowerButton);
            this.Controls.Add(this.getNewStimuliButton);
            this.Controls.Add(this.getOriginalStimuliButton);
            this.Name = "VanillaForm";
            this.Text = "Vanilla Interface";
            ((System.ComponentModel.ISupportInitialize)(this.VanillaRightDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaLeftDpadGlyphImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getOriginalStimuliButton;
        private System.Windows.Forms.Button getNewStimuliButton;
        private System.Windows.Forms.Button V2IsLowerButton;
        private System.Windows.Forms.Button V2IsNotLowerButton;
        private System.Windows.Forms.Label trialNumberLabel;
        private System.Windows.Forms.Label VanillaTaskNumberTitle;
        private System.Windows.Forms.PictureBox VanillaLeftDpadGlyphImage;
        private System.Windows.Forms.PictureBox VanillaRightDpadGlyphImage;
    }
}
namespace EFGHIJ
{
    partial class GamifiedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamifiedForm));
            this.taskInitiatorGridBox = new System.Windows.Forms.GroupBox();
            this.GamifiedSubheadingLabel = new System.Windows.Forms.Label();
            this.GamifiedTitleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.beginTaskButton = new System.Windows.Forms.Button();
            this.VanillaLeftDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.V2IsLowerButton = new System.Windows.Forms.Button();
            this.VanillaRightDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.VanillaDownDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.VanillaUpDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.V2IsNotLowerButton = new System.Windows.Forms.Button();
            this.getNewStimuliButton = new System.Windows.Forms.Button();
            this.getOriginalStimuliButton = new System.Windows.Forms.Button();
            this.VanillaTaskNumberTitle = new System.Windows.Forms.Label();
            this.trialNumberLabel = new System.Windows.Forms.Label();
            this.taskInitiatorGridBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaLeftDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaRightDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaDownDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaUpDpadGlyphImage)).BeginInit();
            this.SuspendLayout();
            // 
            // taskInitiatorGridBox
            // 
            this.taskInitiatorGridBox.Controls.Add(this.GamifiedSubheadingLabel);
            this.taskInitiatorGridBox.Controls.Add(this.GamifiedTitleLabel);
            this.taskInitiatorGridBox.Controls.Add(this.instructionLabel);
            this.taskInitiatorGridBox.Controls.Add(this.beginTaskButton);
            this.taskInitiatorGridBox.Location = new System.Drawing.Point(1, -6);
            this.taskInitiatorGridBox.Name = "taskInitiatorGridBox";
            this.taskInitiatorGridBox.Size = new System.Drawing.Size(802, 457);
            this.taskInitiatorGridBox.TabIndex = 6;
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
            // VanillaLeftDpadGlyphImage
            // 
            this.VanillaLeftDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaLeftDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.LeftGlyphDPadGlyphMap;
            this.VanillaLeftDpadGlyphImage.Location = new System.Drawing.Point(150, 194);
            this.VanillaLeftDpadGlyphImage.Name = "VanillaLeftDpadGlyphImage";
            this.VanillaLeftDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaLeftDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaLeftDpadGlyphImage.TabIndex = 11;
            this.VanillaLeftDpadGlyphImage.TabStop = false;
            // 
            // V2IsLowerButton
            // 
            this.V2IsLowerButton.Location = new System.Drawing.Point(219, 194);
            this.V2IsLowerButton.Name = "V2IsLowerButton";
            this.V2IsLowerButton.Size = new System.Drawing.Size(149, 63);
            this.V2IsLowerButton.TabIndex = 10;
            this.V2IsLowerButton.Text = "New Stimuli Is Lower Intensity";
            this.V2IsLowerButton.UseVisualStyleBackColor = true;
            this.V2IsLowerButton.Click += new System.EventHandler(this.V2IsLowerButton_Click);
            // 
            // VanillaRightDpadGlyphImage
            // 
            this.VanillaRightDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaRightDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.RightGlyphDPadGlyphMap;
            this.VanillaRightDpadGlyphImage.Location = new System.Drawing.Point(585, 194);
            this.VanillaRightDpadGlyphImage.Name = "VanillaRightDpadGlyphImage";
            this.VanillaRightDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaRightDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaRightDpadGlyphImage.TabIndex = 17;
            this.VanillaRightDpadGlyphImage.TabStop = false;
            // 
            // VanillaDownDpadGlyphImage
            // 
            this.VanillaDownDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaDownDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.DownGlyphDPadGlyphMap;
            this.VanillaDownDpadGlyphImage.Location = new System.Drawing.Point(578, 74);
            this.VanillaDownDpadGlyphImage.Name = "VanillaDownDpadGlyphImage";
            this.VanillaDownDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaDownDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaDownDpadGlyphImage.TabIndex = 16;
            this.VanillaDownDpadGlyphImage.TabStop = false;
            // 
            // VanillaUpDpadGlyphImage
            // 
            this.VanillaUpDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaUpDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.UpGlyphDPadGlyphMap;
            this.VanillaUpDpadGlyphImage.Location = new System.Drawing.Point(578, 5);
            this.VanillaUpDpadGlyphImage.Name = "VanillaUpDpadGlyphImage";
            this.VanillaUpDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaUpDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaUpDpadGlyphImage.TabIndex = 15;
            this.VanillaUpDpadGlyphImage.TabStop = false;
            // 
            // V2IsNotLowerButton
            // 
            this.V2IsNotLowerButton.Location = new System.Drawing.Point(430, 194);
            this.V2IsNotLowerButton.Name = "V2IsNotLowerButton";
            this.V2IsNotLowerButton.Size = new System.Drawing.Size(149, 63);
            this.V2IsNotLowerButton.TabIndex = 14;
            this.V2IsNotLowerButton.Text = "New Stimuli Is Higher Intensity";
            this.V2IsNotLowerButton.UseVisualStyleBackColor = true;
            this.V2IsNotLowerButton.Click += new System.EventHandler(this.V2IsNotLowerButton_Click);
            // 
            // getNewStimuliButton
            // 
            this.getNewStimuliButton.Location = new System.Drawing.Point(647, 74);
            this.getNewStimuliButton.Name = "getNewStimuliButton";
            this.getNewStimuliButton.Size = new System.Drawing.Size(149, 63);
            this.getNewStimuliButton.TabIndex = 13;
            this.getNewStimuliButton.Text = "Get New Stimuli Reference (V2)";
            this.getNewStimuliButton.UseVisualStyleBackColor = true;
            this.getNewStimuliButton.Click += new System.EventHandler(this.getNewStimuliButton_Click);
            // 
            // getOriginalStimuliButton
            // 
            this.getOriginalStimuliButton.Location = new System.Drawing.Point(647, 5);
            this.getOriginalStimuliButton.Name = "getOriginalStimuliButton";
            this.getOriginalStimuliButton.Size = new System.Drawing.Size(149, 63);
            this.getOriginalStimuliButton.TabIndex = 12;
            this.getOriginalStimuliButton.Text = "Get Original Stimuli Reference (V1)";
            this.getOriginalStimuliButton.UseVisualStyleBackColor = true;
            this.getOriginalStimuliButton.Click += new System.EventHandler(this.getOriginalStimuliButton_Click);
            // 
            // VanillaTaskNumberTitle
            // 
            this.VanillaTaskNumberTitle.AutoSize = true;
            this.VanillaTaskNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VanillaTaskNumberTitle.Location = new System.Drawing.Point(343, 112);
            this.VanillaTaskNumberTitle.Name = "VanillaTaskNumberTitle";
            this.VanillaTaskNumberTitle.Size = new System.Drawing.Size(114, 20);
            this.VanillaTaskNumberTitle.TabIndex = 19;
            this.VanillaTaskNumberTitle.Text = "Task Number";
            this.VanillaTaskNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trialNumberLabel
            // 
            this.trialNumberLabel.AutoSize = true;
            this.trialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.trialNumberLabel.Location = new System.Drawing.Point(379, 138);
            this.trialNumberLabel.Name = "trialNumberLabel";
            this.trialNumberLabel.Size = new System.Drawing.Size(42, 46);
            this.trialNumberLabel.TabIndex = 18;
            this.trialNumberLabel.Text = "1";
            this.trialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamifiedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskInitiatorGridBox);
            this.Controls.Add(this.VanillaTaskNumberTitle);
            this.Controls.Add(this.trialNumberLabel);
            this.Controls.Add(this.VanillaRightDpadGlyphImage);
            this.Controls.Add(this.VanillaDownDpadGlyphImage);
            this.Controls.Add(this.VanillaUpDpadGlyphImage);
            this.Controls.Add(this.V2IsNotLowerButton);
            this.Controls.Add(this.getNewStimuliButton);
            this.Controls.Add(this.getOriginalStimuliButton);
            this.Controls.Add(this.VanillaLeftDpadGlyphImage);
            this.Controls.Add(this.V2IsLowerButton);
            this.Name = "GamifiedForm";
            this.Text = "GamifiedForm";
            this.taskInitiatorGridBox.ResumeLayout(false);
            this.taskInitiatorGridBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaLeftDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaRightDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaDownDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaUpDpadGlyphImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox taskInitiatorGridBox;
        private System.Windows.Forms.Label GamifiedSubheadingLabel;
        private System.Windows.Forms.Label GamifiedTitleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button beginTaskButton;
        private System.Windows.Forms.PictureBox VanillaLeftDpadGlyphImage;
        private System.Windows.Forms.Button V2IsLowerButton;
        private System.Windows.Forms.PictureBox VanillaRightDpadGlyphImage;
        private System.Windows.Forms.PictureBox VanillaDownDpadGlyphImage;
        private System.Windows.Forms.PictureBox VanillaUpDpadGlyphImage;
        private System.Windows.Forms.Button V2IsNotLowerButton;
        private System.Windows.Forms.Button getNewStimuliButton;
        private System.Windows.Forms.Button getOriginalStimuliButton;
        private System.Windows.Forms.Label VanillaTaskNumberTitle;
        private System.Windows.Forms.Label trialNumberLabel;
    }
}
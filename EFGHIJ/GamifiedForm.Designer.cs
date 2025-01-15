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
            this.VanillaLeftDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.V2IsLowerButton = new System.Windows.Forms.Button();
            this.VanillaRightDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.VanillaDownDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.VanillaUpDpadGlyphImage = new System.Windows.Forms.PictureBox();
            this.V2IsNotLowerButton = new System.Windows.Forms.Button();
            this.getNewStimuliButton = new System.Windows.Forms.Button();
            this.getOriginalStimuliButton = new System.Windows.Forms.Button();
            this.GamifiedTaskNumberTitle = new System.Windows.Forms.Label();
            this.trialNumberLabel = new System.Windows.Forms.Label();
            this.GamifiedScoreTitle = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.GamifiedStreakTitle = new System.Windows.Forms.Label();
            this.streakValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaLeftDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaRightDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaDownDpadGlyphImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaUpDpadGlyphImage)).BeginInit();
            this.SuspendLayout();
            // 
            // VanillaLeftDpadGlyphImage
            // 
            this.VanillaLeftDpadGlyphImage.BackColor = System.Drawing.Color.Transparent;
            this.VanillaLeftDpadGlyphImage.Image = global::EFGHIJ.Properties.Resources.LeftGlyphDPadGlyphMap;
            this.VanillaLeftDpadGlyphImage.Location = new System.Drawing.Point(578, 218);
            this.VanillaLeftDpadGlyphImage.Name = "VanillaLeftDpadGlyphImage";
            this.VanillaLeftDpadGlyphImage.Size = new System.Drawing.Size(63, 63);
            this.VanillaLeftDpadGlyphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VanillaLeftDpadGlyphImage.TabIndex = 11;
            this.VanillaLeftDpadGlyphImage.TabStop = false;
            // 
            // V2IsLowerButton
            // 
            this.V2IsLowerButton.Location = new System.Drawing.Point(647, 218);
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
            this.VanillaRightDpadGlyphImage.Location = new System.Drawing.Point(578, 149);
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
            this.V2IsNotLowerButton.Location = new System.Drawing.Point(647, 149);
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
            // GamifiedTaskNumberTitle
            // 
            this.GamifiedTaskNumberTitle.AutoSize = true;
            this.GamifiedTaskNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamifiedTaskNumberTitle.Location = new System.Drawing.Point(8, 9);
            this.GamifiedTaskNumberTitle.Name = "GamifiedTaskNumberTitle";
            this.GamifiedTaskNumberTitle.Size = new System.Drawing.Size(119, 20);
            this.GamifiedTaskNumberTitle.TabIndex = 19;
            this.GamifiedTaskNumberTitle.Text = "Lock Number:";
            this.GamifiedTaskNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trialNumberLabel
            // 
            this.trialNumberLabel.AutoSize = true;
            this.trialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialNumberLabel.Location = new System.Drawing.Point(133, 9);
            this.trialNumberLabel.Name = "trialNumberLabel";
            this.trialNumberLabel.Size = new System.Drawing.Size(19, 20);
            this.trialNumberLabel.TabIndex = 18;
            this.trialNumberLabel.Text = "1";
            this.trialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamifiedScoreTitle
            // 
            this.GamifiedScoreTitle.AutoSize = true;
            this.GamifiedScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamifiedScoreTitle.Location = new System.Drawing.Point(8, 33);
            this.GamifiedScoreTitle.Name = "GamifiedScoreTitle";
            this.GamifiedScoreTitle.Size = new System.Drawing.Size(76, 20);
            this.GamifiedScoreTitle.TabIndex = 20;
            this.GamifiedScoreTitle.Text = "SCORE:";
            this.GamifiedScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreValueLabel.Location = new System.Drawing.Point(90, 33);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(19, 20);
            this.scoreValueLabel.TabIndex = 21;
            this.scoreValueLabel.Text = "0";
            this.scoreValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamifiedStreakTitle
            // 
            this.GamifiedStreakTitle.AutoSize = true;
            this.GamifiedStreakTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamifiedStreakTitle.Location = new System.Drawing.Point(8, 62);
            this.GamifiedStreakTitle.Name = "GamifiedStreakTitle";
            this.GamifiedStreakTitle.Size = new System.Drawing.Size(67, 20);
            this.GamifiedStreakTitle.TabIndex = 22;
            this.GamifiedStreakTitle.Text = "Streak:";
            this.GamifiedStreakTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // streakValueLabel
            // 
            this.streakValueLabel.AutoSize = true;
            this.streakValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streakValueLabel.Location = new System.Drawing.Point(81, 62);
            this.streakValueLabel.Name = "streakValueLabel";
            this.streakValueLabel.Size = new System.Drawing.Size(19, 20);
            this.streakValueLabel.TabIndex = 23;
            this.streakValueLabel.Text = "0";
            this.streakValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamifiedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.streakValueLabel);
            this.Controls.Add(this.GamifiedStreakTitle);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.GamifiedScoreTitle);
            this.Controls.Add(this.GamifiedTaskNumberTitle);
            this.Controls.Add(this.VanillaLeftDpadGlyphImage);
            this.Controls.Add(this.trialNumberLabel);
            this.Controls.Add(this.V2IsLowerButton);
            this.Controls.Add(this.VanillaRightDpadGlyphImage);
            this.Controls.Add(this.VanillaDownDpadGlyphImage);
            this.Controls.Add(this.VanillaUpDpadGlyphImage);
            this.Controls.Add(this.getNewStimuliButton);
            this.Controls.Add(this.getOriginalStimuliButton);
            this.Controls.Add(this.V2IsNotLowerButton);
            this.Name = "GamifiedForm";
            this.Text = "GamifiedForm";
            ((System.ComponentModel.ISupportInitialize)(this.VanillaLeftDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaRightDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaDownDpadGlyphImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanillaUpDpadGlyphImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox VanillaLeftDpadGlyphImage;
        private System.Windows.Forms.Button V2IsLowerButton;
        private System.Windows.Forms.PictureBox VanillaRightDpadGlyphImage;
        private System.Windows.Forms.PictureBox VanillaDownDpadGlyphImage;
        private System.Windows.Forms.PictureBox VanillaUpDpadGlyphImage;
        private System.Windows.Forms.Button V2IsNotLowerButton;
        private System.Windows.Forms.Button getNewStimuliButton;
        private System.Windows.Forms.Button getOriginalStimuliButton;
        private System.Windows.Forms.Label GamifiedTaskNumberTitle;
        private System.Windows.Forms.Label trialNumberLabel;
        private System.Windows.Forms.Label GamifiedScoreTitle;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label GamifiedStreakTitle;
        private System.Windows.Forms.Label streakValueLabel;
    }
}
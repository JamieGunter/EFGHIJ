namespace EFGHIJ
{
    partial class TaskConclusionFormGamified
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
            this.OkButton = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreLeaderboardDGV = new System.Windows.Forms.DataGridView();
            this.finalScoresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreLeaderboardDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 297);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(542, 127);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(95, 9);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(375, 50);
            this.ThankYouLabel.TabIndex = 3;
            this.ThankYouLabel.Text = "Thank You For Participating!\r\nThis Task Section Has Concluded!";
            this.ThankYouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.InstructionLabel.Location = new System.Drawing.Point(7, 66);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(547, 78);
            this.InstructionLabel.TabIndex = 4;
            this.InstructionLabel.Text = "Please read below for your leaderboard score, and click\r\n\"Ok\" when you are finish" +
    "ed to go back to the selection\r\nscreen!";
            this.InstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Score Leaderboard:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLeaderboardDGV
            // 
            this.ScoreLeaderboardDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreLeaderboardDGV.Location = new System.Drawing.Point(624, 42);
            this.ScoreLeaderboardDGV.Name = "ScoreLeaderboardDGV";
            this.ScoreLeaderboardDGV.Size = new System.Drawing.Size(164, 396);
            this.ScoreLeaderboardDGV.TabIndex = 32;
            // 
            // finalScoresLabel
            // 
            this.finalScoresLabel.AutoSize = true;
            this.finalScoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.finalScoresLabel.Location = new System.Drawing.Point(7, 172);
            this.finalScoresLabel.Name = "finalScoresLabel";
            this.finalScoresLabel.Size = new System.Drawing.Size(215, 52);
            this.finalScoresLabel.TabIndex = 34;
            this.finalScoresLabel.Text = "Your final score was:\r\nThis places you: ";
            // 
            // TaskConclusionFormGamified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalScoresLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLeaderboardDGV);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "TaskConclusionFormGamified";
            this.Text = "This Task Has Concluded";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreLeaderboardDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ScoreLeaderboardDGV;
        private System.Windows.Forms.Label finalScoresLabel;
    }
}
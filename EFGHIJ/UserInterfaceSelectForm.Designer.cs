namespace EFGHIJ
{
    partial class userInterfaceSelectForm
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
            this.gamifiedButton = new System.Windows.Forms.Button();
            this.vanillaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamifiedButton
            // 
            this.gamifiedButton.Location = new System.Drawing.Point(118, 155);
            this.gamifiedButton.Name = "gamifiedButton";
            this.gamifiedButton.Size = new System.Drawing.Size(200, 116);
            this.gamifiedButton.TabIndex = 0;
            this.gamifiedButton.Text = "Gamified User Interface";
            this.gamifiedButton.UseVisualStyleBackColor = true;
            this.gamifiedButton.Click += new System.EventHandler(this.gamifiedButton_Click);
            // 
            // vanillaButton
            // 
            this.vanillaButton.Location = new System.Drawing.Point(478, 155);
            this.vanillaButton.Name = "vanillaButton";
            this.vanillaButton.Size = new System.Drawing.Size(200, 116);
            this.vanillaButton.TabIndex = 1;
            this.vanillaButton.Text = "Vanilla User Interface";
            this.vanillaButton.UseVisualStyleBackColor = true;
            // 
            // userInterfaceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vanillaButton);
            this.Controls.Add(this.gamifiedButton);
            this.Name = "userInterfaceSelectForm";
            this.Text = "User Interface Select";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gamifiedButton;
        private System.Windows.Forms.Button vanillaButton;
    }
}
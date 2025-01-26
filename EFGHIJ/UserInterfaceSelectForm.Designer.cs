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
            this.vanillaButtonVersion1 = new System.Windows.Forms.Button();
            this.vanillaButtonVersion2 = new System.Windows.Forms.Button();
            this.vanillaButtonVersion3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vanillaButtonVersion1
            // 
            this.vanillaButtonVersion1.Location = new System.Drawing.Point(81, 147);
            this.vanillaButtonVersion1.Name = "vanillaButtonVersion1";
            this.vanillaButtonVersion1.Size = new System.Drawing.Size(200, 116);
            this.vanillaButtonVersion1.TabIndex = 1;
            this.vanillaButtonVersion1.Text = "[Version 1] Vanilla User Interface";
            this.vanillaButtonVersion1.UseVisualStyleBackColor = true;
            this.vanillaButtonVersion1.Click += new System.EventHandler(this.vanillaButtonVersion1_Click_1);
            // 
            // vanillaButtonVersion2
            // 
            this.vanillaButtonVersion2.Location = new System.Drawing.Point(308, 147);
            this.vanillaButtonVersion2.Name = "vanillaButtonVersion2";
            this.vanillaButtonVersion2.Size = new System.Drawing.Size(200, 116);
            this.vanillaButtonVersion2.TabIndex = 2;
            this.vanillaButtonVersion2.Text = "[Version 2] Vanilla User Interface";
            this.vanillaButtonVersion2.UseVisualStyleBackColor = true;
            this.vanillaButtonVersion2.Click += new System.EventHandler(this.vanillaButtonVersion2_Click);
            // 
            // vanillaButtonVersion3
            // 
            this.vanillaButtonVersion3.Location = new System.Drawing.Point(536, 147);
            this.vanillaButtonVersion3.Name = "vanillaButtonVersion3";
            this.vanillaButtonVersion3.Size = new System.Drawing.Size(200, 116);
            this.vanillaButtonVersion3.TabIndex = 3;
            this.vanillaButtonVersion3.Text = "[Version 3] Vanilla User Interface";
            this.vanillaButtonVersion3.UseVisualStyleBackColor = true;
            this.vanillaButtonVersion3.Click += new System.EventHandler(this.vanillaButtonVersion3_Click);
            // 
            // userInterfaceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vanillaButtonVersion3);
            this.Controls.Add(this.vanillaButtonVersion2);
            this.Controls.Add(this.vanillaButtonVersion1);
            this.Name = "userInterfaceSelectForm";
            this.Text = "User Interface Select";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button vanillaButtonVersion1;
        private System.Windows.Forms.Button vanillaButtonVersion2;
        private System.Windows.Forms.Button vanillaButtonVersion3;
    }
}
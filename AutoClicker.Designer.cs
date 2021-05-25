namespace French_Fri_Clicker
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.button_toclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_toclose
            // 
            this.button_toclose.BackColor = System.Drawing.Color.Transparent;
            this.button_toclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_toclose.FlatAppearance.BorderSize = 0;
            this.button_toclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_toclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_toclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_toclose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_toclose.Location = new System.Drawing.Point(400, -1);
            this.button_toclose.Name = "button_toclose";
            this.button_toclose.Size = new System.Drawing.Size(47, 25);
            this.button_toclose.TabIndex = 36;
            this.button_toclose.UseVisualStyleBackColor = false;
            this.button_toclose.Click += new System.EventHandler(this.button_toclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Close Soon Or Lose Fries. No one like AutoClicker\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(443, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_toclose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_toclose;
        private System.Windows.Forms.Label label1;
    }
}
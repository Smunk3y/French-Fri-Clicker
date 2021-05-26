namespace French_Fri_Clicker
{
    partial class xxCheatTogle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xxCheatTogle));
            this.button_opencheatmeny = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_opencheatmeny
            // 
            this.button_opencheatmeny.BackColor = System.Drawing.Color.Transparent;
            this.button_opencheatmeny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_opencheatmeny.FlatAppearance.BorderSize = 0;
            this.button_opencheatmeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_opencheatmeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_opencheatmeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_opencheatmeny.Location = new System.Drawing.Point(12, 185);
            this.button_opencheatmeny.Name = "button_opencheatmeny";
            this.button_opencheatmeny.Size = new System.Drawing.Size(303, 135);
            this.button_opencheatmeny.TabIndex = 3;
            this.button_opencheatmeny.UseVisualStyleBackColor = false;
            this.button_opencheatmeny.Click += new System.EventHandler(this.button_opencheatmeny_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(330, 306);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(73, 93);
            this.button_close.TabIndex = 4;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // xxCheatTogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_opencheatmeny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xxCheatTogle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xxCheatTogle";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_opencheatmeny;
        private System.Windows.Forms.Button button_close;
    }
}
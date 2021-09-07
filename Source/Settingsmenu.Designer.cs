namespace French_Fri_Clicker
{
    partial class Settingsmenu
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
            this.components = new System.ComponentModel.Container();
            this.button_close = new System.Windows.Forms.Button();
            this.button_opencheatmeny = new System.Windows.Forms.Button();
            this.button_cheattoggle = new System.Windows.Forms.Button();
            this.label_cheatsident = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_fris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1785, 900);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(129, 169);
            this.button_close.TabIndex = 1;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_opencheatmeny
            // 
            this.button_opencheatmeny.BackColor = System.Drawing.Color.Transparent;
            this.button_opencheatmeny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_opencheatmeny.FlatAppearance.BorderSize = 0;
            this.button_opencheatmeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_opencheatmeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_opencheatmeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_opencheatmeny.Location = new System.Drawing.Point(12, 969);
            this.button_opencheatmeny.Name = "button_opencheatmeny";
            this.button_opencheatmeny.Size = new System.Drawing.Size(222, 99);
            this.button_opencheatmeny.TabIndex = 2;
            this.button_opencheatmeny.UseVisualStyleBackColor = false;
            this.button_opencheatmeny.Click += new System.EventHandler(this.button_opencheatmeny_Click);
            // 
            // button_cheattoggle
            // 
            this.button_cheattoggle.BackColor = System.Drawing.Color.Transparent;
            this.button_cheattoggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cheattoggle.FlatAppearance.BorderSize = 0;
            this.button_cheattoggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_cheattoggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_cheattoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cheattoggle.Location = new System.Drawing.Point(12, 921);
            this.button_cheattoggle.Name = "button_cheattoggle";
            this.button_cheattoggle.Size = new System.Drawing.Size(222, 42);
            this.button_cheattoggle.TabIndex = 3;
            this.button_cheattoggle.UseVisualStyleBackColor = false;
            this.button_cheattoggle.Click += new System.EventHandler(this.button_cheattoggle_Click);
            // 
            // label_cheatsident
            // 
            this.label_cheatsident.AutoSize = true;
            this.label_cheatsident.BackColor = System.Drawing.Color.Transparent;
            this.label_cheatsident.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cheatsident.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_cheatsident.Location = new System.Drawing.Point(161, 882);
            this.label_cheatsident.Name = "label_cheatsident";
            this.label_cheatsident.Size = new System.Drawing.Size(52, 39);
            this.label_cheatsident.TabIndex = 53;
            this.label_cheatsident.Text = "No";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_fris
            // 
            this.label_fris.AutoSize = true;
            this.label_fris.BackColor = System.Drawing.Color.Transparent;
            this.label_fris.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fris.ForeColor = System.Drawing.SystemColors.Control;
            this.label_fris.Location = new System.Drawing.Point(188, 113);
            this.label_fris.Name = "label_fris";
            this.label_fris.Size = new System.Drawing.Size(207, 60);
            this.label_fris.TabIndex = 89;
            this.label_fris.Text = "V2 Beta 1";
            this.label_fris.Click += new System.EventHandler(this.label_fris_Click);
            // 
            // Settingsmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::French_Fri_Clicker.Properties.Resources.Settingsmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label_fris);
            this.Controls.Add(this.label_cheatsident);
            this.Controls.Add(this.button_cheattoggle);
            this.Controls.Add(this.button_opencheatmeny);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settingsmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zx";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_opencheatmeny;
        private System.Windows.Forms.Button button_cheattoggle;
        private System.Windows.Forms.Label label_cheatsident;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_fris;
    }
}
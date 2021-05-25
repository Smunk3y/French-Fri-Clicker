namespace French_Fri_Clicker
{
    partial class SaveGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.button_save1Save = new System.Windows.Forms.Button();
            this.button_save1Load = new System.Windows.Forms.Button();
            this.button_save1Wipe = new System.Windows.Forms.Button();
            this.label_lastsave = new System.Windows.Forms.Label();
            this.button_unload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1772, 905);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(136, 175);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_save1Save
            // 
            this.button_save1Save.BackColor = System.Drawing.Color.Transparent;
            this.button_save1Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save1Save.FlatAppearance.BorderSize = 0;
            this.button_save1Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_save1Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_save1Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save1Save.Location = new System.Drawing.Point(34, 402);
            this.button_save1Save.Name = "button_save1Save";
            this.button_save1Save.Size = new System.Drawing.Size(509, 255);
            this.button_save1Save.TabIndex = 3;
            this.button_save1Save.UseVisualStyleBackColor = false;
            this.button_save1Save.Click += new System.EventHandler(this.button_save1Save_Click);
            // 
            // button_save1Load
            // 
            this.button_save1Load.BackColor = System.Drawing.Color.Transparent;
            this.button_save1Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save1Load.FlatAppearance.BorderSize = 0;
            this.button_save1Load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_save1Load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_save1Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save1Load.Location = new System.Drawing.Point(631, 388);
            this.button_save1Load.Name = "button_save1Load";
            this.button_save1Load.Size = new System.Drawing.Size(509, 255);
            this.button_save1Load.TabIndex = 4;
            this.button_save1Load.UseVisualStyleBackColor = false;
            this.button_save1Load.Click += new System.EventHandler(this.button_save1Load_Click);
            // 
            // button_save1Wipe
            // 
            this.button_save1Wipe.BackColor = System.Drawing.Color.Transparent;
            this.button_save1Wipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save1Wipe.FlatAppearance.BorderSize = 0;
            this.button_save1Wipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_save1Wipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_save1Wipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save1Wipe.Location = new System.Drawing.Point(1217, 388);
            this.button_save1Wipe.Name = "button_save1Wipe";
            this.button_save1Wipe.Size = new System.Drawing.Size(509, 255);
            this.button_save1Wipe.TabIndex = 5;
            this.button_save1Wipe.UseVisualStyleBackColor = false;
            this.button_save1Wipe.Click += new System.EventHandler(this.button_save1Wipe_Click);
            // 
            // label_lastsave
            // 
            this.label_lastsave.AutoSize = true;
            this.label_lastsave.BackColor = System.Drawing.Color.Transparent;
            this.label_lastsave.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastsave.ForeColor = System.Drawing.SystemColors.Control;
            this.label_lastsave.Location = new System.Drawing.Point(206, 1019);
            this.label_lastsave.Name = "label_lastsave";
            this.label_lastsave.Size = new System.Drawing.Size(137, 43);
            this.label_lastsave.TabIndex = 11;
            this.label_lastsave.Text = "No Save";
            // 
            // button_unload
            // 
            this.button_unload.BackColor = System.Drawing.Color.Transparent;
            this.button_unload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_unload.FlatAppearance.BorderSize = 0;
            this.button_unload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_unload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_unload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_unload.Location = new System.Drawing.Point(1772, 191);
            this.button_unload.Name = "button_unload";
            this.button_unload.Size = new System.Drawing.Size(136, 651);
            this.button_unload.TabIndex = 12;
            this.button_unload.UseVisualStyleBackColor = false;
            this.button_unload.Click += new System.EventHandler(this.button_unload_Click);
            // 
            // SaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::French_Fri_Clicker.Properties.Resources.SaveMenu3;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button_unload);
            this.Controls.Add(this.label_lastsave);
            this.Controls.Add(this.button_save1Wipe);
            this.Controls.Add(this.button_save1Load);
            this.Controls.Add(this.button_save1Save);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveGame";
            this.Text = "SaveGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaveGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save1Save;
        private System.Windows.Forms.Button button_save1Load;
        private System.Windows.Forms.Button button_save1Wipe;
        private System.Windows.Forms.Label label_lastsave;
        private System.Windows.Forms.Button button_unload;
    }
}
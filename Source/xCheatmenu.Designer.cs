namespace French_Fri_Clicker
{
    partial class xCheatmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xCheatmenu));
            this.button_close = new System.Windows.Forms.Button();
            this.button_openfries = new System.Windows.Forms.Button();
            this.button_FPS = new System.Windows.Forms.Button();
            this.button_openfpc = new System.Windows.Forms.Button();
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
            this.button_close.Location = new System.Drawing.Point(1784, 900);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(129, 169);
            this.button_close.TabIndex = 1;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_openfries
            // 
            this.button_openfries.BackColor = System.Drawing.Color.Transparent;
            this.button_openfries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_openfries.FlatAppearance.BorderSize = 0;
            this.button_openfries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_openfries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_openfries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openfries.Location = new System.Drawing.Point(12, 86);
            this.button_openfries.Name = "button_openfries";
            this.button_openfries.Size = new System.Drawing.Size(858, 424);
            this.button_openfries.TabIndex = 2;
            this.button_openfries.UseVisualStyleBackColor = false;
            this.button_openfries.Click += new System.EventHandler(this.button_openfries_Click);
            // 
            // button_FPS
            // 
            this.button_FPS.BackColor = System.Drawing.Color.Transparent;
            this.button_FPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FPS.FlatAppearance.BorderSize = 0;
            this.button_FPS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_FPS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_FPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FPS.Location = new System.Drawing.Point(12, 555);
            this.button_FPS.Name = "button_FPS";
            this.button_FPS.Size = new System.Drawing.Size(858, 424);
            this.button_FPS.TabIndex = 3;
            this.button_FPS.UseVisualStyleBackColor = false;
            this.button_FPS.Click += new System.EventHandler(this.button_FPS_Click);
            // 
            // button_openfpc
            // 
            this.button_openfpc.BackColor = System.Drawing.Color.Transparent;
            this.button_openfpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_openfpc.FlatAppearance.BorderSize = 0;
            this.button_openfpc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_openfpc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_openfpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openfpc.Location = new System.Drawing.Point(958, 86);
            this.button_openfpc.Name = "button_openfpc";
            this.button_openfpc.Size = new System.Drawing.Size(858, 424);
            this.button_openfpc.TabIndex = 4;
            this.button_openfpc.UseVisualStyleBackColor = false;
            this.button_openfpc.Click += new System.EventHandler(this.button_openfpc_Click);
            // 
            // xCheatmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button_openfpc);
            this.Controls.Add(this.button_FPS);
            this.Controls.Add(this.button_openfries);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xCheatmenu";
            this.Text = "\\";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_openfries;
        private System.Windows.Forms.Button button_FPS;
        private System.Windows.Forms.Button button_openfpc;
    }
}
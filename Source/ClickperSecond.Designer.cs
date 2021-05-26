namespace French_Fri_Clicker
{
    partial class ClickperSecond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickperSecond));
            this.label_amtofPotatoclick = new System.Windows.Forms.Label();
            this.button_clickme = new System.Windows.Forms.Button();
            this.label_clicks = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_secondsleft = new System.Windows.Forms.Label();
            this.label_inprogress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_amtofPotatoclick
            // 
            this.label_amtofPotatoclick.AutoSize = true;
            this.label_amtofPotatoclick.BackColor = System.Drawing.Color.Transparent;
            this.label_amtofPotatoclick.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amtofPotatoclick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_amtofPotatoclick.Location = new System.Drawing.Point(367, 558);
            this.label_amtofPotatoclick.Name = "label_amtofPotatoclick";
            this.label_amtofPotatoclick.Size = new System.Drawing.Size(35, 39);
            this.label_amtofPotatoclick.TabIndex = 43;
            this.label_amtofPotatoclick.Text = "0";
            // 
            // button_clickme
            // 
            this.button_clickme.BackColor = System.Drawing.Color.Transparent;
            this.button_clickme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clickme.FlatAppearance.BorderSize = 0;
            this.button_clickme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_clickme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_clickme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clickme.Location = new System.Drawing.Point(0, 2);
            this.button_clickme.Name = "button_clickme";
            this.button_clickme.Size = new System.Drawing.Size(292, 321);
            this.button_clickme.TabIndex = 44;
            this.button_clickme.UseVisualStyleBackColor = false;
            this.button_clickme.Click += new System.EventHandler(this.button_clickme_Click);
            // 
            // label_clicks
            // 
            this.label_clicks.AutoSize = true;
            this.label_clicks.BackColor = System.Drawing.Color.Transparent;
            this.label_clicks.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clicks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_clicks.Location = new System.Drawing.Point(149, 411);
            this.label_clicks.Name = "label_clicks";
            this.label_clicks.Size = new System.Drawing.Size(35, 39);
            this.label_clicks.TabIndex = 45;
            this.label_clicks.Text = "0";
            this.label_clicks.Click += new System.EventHandler(this.label_clicks_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(481, 458);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(116, 139);
            this.button_close.TabIndex = 46;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Transparent;
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.FlatAppearance.BorderSize = 0;
            this.button_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Location = new System.Drawing.Point(481, 12);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(116, 112);
            this.button_reset.TabIndex = 47;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_secondsleft
            // 
            this.label_secondsleft.AutoSize = true;
            this.label_secondsleft.BackColor = System.Drawing.Color.Transparent;
            this.label_secondsleft.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secondsleft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_secondsleft.Location = new System.Drawing.Point(265, 510);
            this.label_secondsleft.Name = "label_secondsleft";
            this.label_secondsleft.Size = new System.Drawing.Size(48, 39);
            this.label_secondsleft.TabIndex = 48;
            this.label_secondsleft.Text = "10";
            // 
            // label_inprogress
            // 
            this.label_inprogress.AutoSize = true;
            this.label_inprogress.BackColor = System.Drawing.Color.Transparent;
            this.label_inprogress.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inprogress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_inprogress.Location = new System.Drawing.Point(191, 458);
            this.label_inprogress.Name = "label_inprogress";
            this.label_inprogress.Size = new System.Drawing.Size(185, 39);
            this.label_inprogress.TabIndex = 49;
            this.label_inprogress.Text = "Ready To Go";
            this.label_inprogress.Click += new System.EventHandler(this.label_inprogress_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.label_inprogress);
            this.Controls.Add(this.label_secondsleft);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_clicks);
            this.Controls.Add(this.button_clickme);
            this.Controls.Add(this.label_amtofPotatoclick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_amtofPotatoclick;
        private System.Windows.Forms.Button button_clickme;
        private System.Windows.Forms.Label label_clicks;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_secondsleft;
        private System.Windows.Forms.Label label_inprogress;
    }
}
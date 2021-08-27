namespace French_Fri_Clicker
{
    partial class StockMarketpg1
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
            this.exitbutton = new System.Windows.Forms.Button();
            this.button_applu = new System.Windows.Forms.Button();
            this.label_timmmer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_secondsss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Gotham Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(1828, 952);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(80, 116);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // button_applu
            // 
            this.button_applu.BackColor = System.Drawing.Color.Transparent;
            this.button_applu.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_applu.FlatAppearance.BorderSize = 0;
            this.button_applu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_applu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_applu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_applu.Font = new System.Drawing.Font("Gotham Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_applu.Location = new System.Drawing.Point(1221, 0);
            this.button_applu.Name = "button_applu";
            this.button_applu.Size = new System.Drawing.Size(123, 51);
            this.button_applu.TabIndex = 94;
            this.button_applu.UseVisualStyleBackColor = false;
            this.button_applu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_timmmer
            // 
            this.label_timmmer.AutoSize = true;
            this.label_timmmer.BackColor = System.Drawing.Color.Transparent;
            this.label_timmmer.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timmmer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_timmmer.Location = new System.Drawing.Point(1143, 1049);
            this.label_timmmer.Name = "label_timmmer";
            this.label_timmmer.Size = new System.Drawing.Size(49, 36);
            this.label_timmmer.TabIndex = 95;
            this.label_timmmer.Text = "60";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(918, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 36);
            this.textBox1.TabIndex = 96;
            // 
            // label_secondsss
            // 
            this.label_secondsss.AutoSize = true;
            this.label_secondsss.BackColor = System.Drawing.Color.Transparent;
            this.label_secondsss.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secondsss.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_secondsss.Location = new System.Drawing.Point(1183, 1049);
            this.label_secondsss.Name = "label_secondsss";
            this.label_secondsss.Size = new System.Drawing.Size(125, 36);
            this.label_secondsss.TabIndex = 97;
            this.label_secondsss.Text = "Seconds";
            // 
            // StockMarketpg1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::French_Fri_Clicker.Properties.Resources.Stock_Market_German;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label_secondsss);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_timmmer);
            this.Controls.Add(this.button_applu);
            this.Controls.Add(this.exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockMarketpg1";
            this.Text = "StockMarketpg1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockMarketpg1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button button_applu;
        private System.Windows.Forms.Label label_timmmer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_secondsss;
    }
}
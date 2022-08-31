namespace car_rental
{
    partial class adDashboard
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
            this.lbl_hello = new System.Windows.Forms.Label();
            this.butt_logout = new System.Windows.Forms.Button();
            this.butt_mngCatalog = new System.Windows.Forms.Button();
            this.but_userMng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(302, 31);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(34, 13);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "Hello,";
            // 
            // butt_logout
            // 
            this.butt_logout.Location = new System.Drawing.Point(292, 100);
            this.butt_logout.Name = "butt_logout";
            this.butt_logout.Size = new System.Drawing.Size(75, 23);
            this.butt_logout.TabIndex = 1;
            this.butt_logout.Text = "Log Out!";
            this.butt_logout.UseVisualStyleBackColor = true;
            this.butt_logout.Click += new System.EventHandler(this.butt_logout_Click);
            // 
            // butt_mngCatalog
            // 
            this.butt_mngCatalog.Location = new System.Drawing.Point(113, 54);
            this.butt_mngCatalog.Name = "butt_mngCatalog";
            this.butt_mngCatalog.Size = new System.Drawing.Size(145, 23);
            this.butt_mngCatalog.TabIndex = 2;
            this.butt_mngCatalog.Text = "Catalog Mangmenet";
            this.butt_mngCatalog.UseVisualStyleBackColor = true;
            this.butt_mngCatalog.Click += new System.EventHandler(this.butt_mngCatalog_Click);
            // 
            // but_userMng
            // 
            this.but_userMng.Location = new System.Drawing.Point(408, 54);
            this.but_userMng.Name = "but_userMng";
            this.but_userMng.Size = new System.Drawing.Size(160, 23);
            this.but_userMng.TabIndex = 3;
            this.but_userMng.Text = "User Mangement";
            this.but_userMng.UseVisualStyleBackColor = true;
            this.but_userMng.Click += new System.EventHandler(this.but_userMng_Click);
            // 
            // adDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 143);
            this.Controls.Add(this.but_userMng);
            this.Controls.Add(this.butt_mngCatalog);
            this.Controls.Add(this.butt_logout);
            this.Controls.Add(this.lbl_hello);
            this.Name = "adDashboard";
            this.Text = "adDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Button butt_logout;
        private System.Windows.Forms.Button butt_mngCatalog;
        private System.Windows.Forms.Button but_userMng;
    }
}
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
            this.go_to_CatalogMain = new System.Windows.Forms.Button();
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
            this.butt_logout.Location = new System.Drawing.Point(305, 280);
            this.butt_logout.Name = "butt_logout";
            this.butt_logout.Size = new System.Drawing.Size(75, 23);
            this.butt_logout.TabIndex = 1;
            this.butt_logout.Text = "Log Out!";
            this.butt_logout.UseVisualStyleBackColor = true;
            this.butt_logout.Click += new System.EventHandler(this.butt_logout_Click);
            // 
            // go_to_CatalogMain
            // 
            this.go_to_CatalogMain.Location = new System.Drawing.Point(122, 215);
            this.go_to_CatalogMain.Name = "go_to_CatalogMain";
            this.go_to_CatalogMain.Size = new System.Drawing.Size(145, 23);
            this.go_to_CatalogMain.TabIndex = 2;
            this.go_to_CatalogMain.Text = "Vehicle Catalog";
            this.go_to_CatalogMain.UseVisualStyleBackColor = true;
            this.go_to_CatalogMain.Click += new System.EventHandler(this.go_to_CatalogMain_Click);
            // 
            // adDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go_to_CatalogMain);
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
        private System.Windows.Forms.Button go_to_CatalogMain;
    }
}
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
            this.butt_PurchaseHIsotry = new System.Windows.Forms.Button();
            this.panel_Purchase = new System.Windows.Forms.Panel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_byWho = new System.Windows.Forms.Label();
            this.cb_userPurhcaes = new System.Windows.Forms.ComboBox();
            this.cb_load = new System.Windows.Forms.ComboBox();
            this.rdbutt_all = new System.Windows.Forms.RadioButton();
            this.rdButt_ByUser = new System.Windows.Forms.RadioButton();
            this.lbl_totalPur = new System.Windows.Forms.Label();
            this.panel_Purchase.SuspendLayout();
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
            this.butt_logout.Location = new System.Drawing.Point(290, 261);
            this.butt_logout.Name = "butt_logout";
            this.butt_logout.Size = new System.Drawing.Size(75, 23);
            this.butt_logout.TabIndex = 1;
            this.butt_logout.Text = "Log Out!";
            this.butt_logout.UseVisualStyleBackColor = true;
            this.butt_logout.Click += new System.EventHandler(this.butt_logout_Click);
            // 
            // butt_mngCatalog
            // 
            this.butt_mngCatalog.Location = new System.Drawing.Point(87, 54);
            this.butt_mngCatalog.Name = "butt_mngCatalog";
            this.butt_mngCatalog.Size = new System.Drawing.Size(145, 23);
            this.butt_mngCatalog.TabIndex = 2;
            this.butt_mngCatalog.Text = "Catalog Mangmenet";
            this.butt_mngCatalog.UseVisualStyleBackColor = true;
            this.butt_mngCatalog.Click += new System.EventHandler(this.butt_mngCatalog_Click);
            // 
            // but_userMng
            // 
            this.but_userMng.Location = new System.Drawing.Point(420, 54);
            this.but_userMng.Name = "but_userMng";
            this.but_userMng.Size = new System.Drawing.Size(160, 23);
            this.but_userMng.TabIndex = 3;
            this.but_userMng.Text = "User Mangement";
            this.but_userMng.UseVisualStyleBackColor = true;
            this.but_userMng.Click += new System.EventHandler(this.but_userMng_Click);
            // 
            // butt_PurchaseHIsotry
            // 
            this.butt_PurchaseHIsotry.Location = new System.Drawing.Point(257, 54);
            this.butt_PurchaseHIsotry.Name = "butt_PurchaseHIsotry";
            this.butt_PurchaseHIsotry.Size = new System.Drawing.Size(145, 23);
            this.butt_PurchaseHIsotry.TabIndex = 4;
            this.butt_PurchaseHIsotry.Text = "Purchase History";
            this.butt_PurchaseHIsotry.UseVisualStyleBackColor = true;
            this.butt_PurchaseHIsotry.Click += new System.EventHandler(this.butt_PurchaseHIsotry_Click);
            // 
            // panel_Purchase
            // 
            this.panel_Purchase.BackColor = System.Drawing.Color.GreenYellow;
            this.panel_Purchase.Controls.Add(this.lbl_Time);
            this.panel_Purchase.Controls.Add(this.lbl_Date);
            this.panel_Purchase.Controls.Add(this.lbl_byWho);
            this.panel_Purchase.Controls.Add(this.cb_userPurhcaes);
            this.panel_Purchase.Controls.Add(this.cb_load);
            this.panel_Purchase.Controls.Add(this.rdbutt_all);
            this.panel_Purchase.Controls.Add(this.rdButt_ByUser);
            this.panel_Purchase.Controls.Add(this.lbl_totalPur);
            this.panel_Purchase.Location = new System.Drawing.Point(87, 84);
            this.panel_Purchase.Name = "panel_Purchase";
            this.panel_Purchase.Size = new System.Drawing.Size(493, 171);
            this.panel_Purchase.TabIndex = 5;
            this.panel_Purchase.Visible = false;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(319, 90);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(81, 13);
            this.lbl_Time.TabIndex = 7;
            this.lbl_Time.Text = "Purchase Time:";
            this.lbl_Time.Visible = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(153, 90);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(81, 13);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Purchase Date:";
            this.lbl_Date.Visible = false;
            // 
            // lbl_byWho
            // 
            this.lbl_byWho.AutoSize = true;
            this.lbl_byWho.Location = new System.Drawing.Point(34, 90);
            this.lbl_byWho.Name = "lbl_byWho";
            this.lbl_byWho.Size = new System.Drawing.Size(59, 13);
            this.lbl_byWho.TabIndex = 5;
            this.lbl_byWho.Text = "Bought By:";
            this.lbl_byWho.Visible = false;
            // 
            // cb_userPurhcaes
            // 
            this.cb_userPurhcaes.Enabled = false;
            this.cb_userPurhcaes.FormattingEnabled = true;
            this.cb_userPurhcaes.Location = new System.Drawing.Point(184, 54);
            this.cb_userPurhcaes.Name = "cb_userPurhcaes";
            this.cb_userPurhcaes.Size = new System.Drawing.Size(121, 21);
            this.cb_userPurhcaes.TabIndex = 4;
            this.cb_userPurhcaes.Visible = false;
            this.cb_userPurhcaes.SelectedIndexChanged += new System.EventHandler(this.cb_userPurhcaes_SelectedIndexChanged);
            // 
            // cb_load
            // 
            this.cb_load.FormattingEnabled = true;
            this.cb_load.Location = new System.Drawing.Point(170, 27);
            this.cb_load.Name = "cb_load";
            this.cb_load.Size = new System.Drawing.Size(145, 21);
            this.cb_load.TabIndex = 3;
            this.cb_load.SelectedIndexChanged += new System.EventHandler(this.cb_load_SelectedIndexChanged);
            // 
            // rdbutt_all
            // 
            this.rdbutt_all.AutoSize = true;
            this.rdbutt_all.Location = new System.Drawing.Point(385, 31);
            this.rdbutt_all.Name = "rdbutt_all";
            this.rdbutt_all.Size = new System.Drawing.Size(82, 17);
            this.rdbutt_all.TabIndex = 2;
            this.rdbutt_all.TabStop = true;
            this.rdbutt_all.Text = "By Products";
            this.rdbutt_all.UseVisualStyleBackColor = true;
            this.rdbutt_all.CheckedChanged += new System.EventHandler(this.rdbutt_all_CheckedChanged);
            // 
            // rdButt_ByUser
            // 
            this.rdButt_ByUser.AutoSize = true;
            this.rdButt_ByUser.Location = new System.Drawing.Point(385, 8);
            this.rdButt_ByUser.Name = "rdButt_ByUser";
            this.rdButt_ByUser.Size = new System.Drawing.Size(62, 17);
            this.rdButt_ByUser.TabIndex = 1;
            this.rdButt_ByUser.TabStop = true;
            this.rdButt_ByUser.Text = "By User";
            this.rdButt_ByUser.UseVisualStyleBackColor = true;
            this.rdButt_ByUser.CheckedChanged += new System.EventHandler(this.rdButt_ByUser_CheckedChanged);
            // 
            // lbl_totalPur
            // 
            this.lbl_totalPur.AutoSize = true;
            this.lbl_totalPur.Location = new System.Drawing.Point(110, 10);
            this.lbl_totalPur.Name = "lbl_totalPur";
            this.lbl_totalPur.Size = new System.Drawing.Size(87, 13);
            this.lbl_totalPur.TabIndex = 0;
            this.lbl_totalPur.Text = "Total Purchases:";
            // 
            // adDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::car_rental.Properties.Resources.LamboAven;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 296);
            this.Controls.Add(this.panel_Purchase);
            this.Controls.Add(this.butt_PurchaseHIsotry);
            this.Controls.Add(this.but_userMng);
            this.Controls.Add(this.butt_mngCatalog);
            this.Controls.Add(this.butt_logout);
            this.Controls.Add(this.lbl_hello);
            this.Name = "adDashboard";
            this.Text = "adDashboard";
            this.panel_Purchase.ResumeLayout(false);
            this.panel_Purchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Button butt_logout;
        private System.Windows.Forms.Button butt_mngCatalog;
        private System.Windows.Forms.Button but_userMng;
        private System.Windows.Forms.Button butt_PurchaseHIsotry;
        private System.Windows.Forms.Panel panel_Purchase;
        private System.Windows.Forms.Label lbl_totalPur;
        private System.Windows.Forms.ComboBox cb_load;
        private System.Windows.Forms.RadioButton rdbutt_all;
        private System.Windows.Forms.RadioButton rdButt_ByUser;
        private System.Windows.Forms.ComboBox cb_userPurhcaes;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_byWho;
    }
}
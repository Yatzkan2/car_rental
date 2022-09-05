namespace car_rental
{
    partial class UserDashBoard
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
            this.go_to_VehicleType = new System.Windows.Forms.Button();
            this.butt_logout = new System.Windows.Forms.Button();
            this.butt_Purchase = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_purch = new System.Windows.Forms.Panel();
            this.butt_HidePur = new System.Windows.Forms.Button();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.cb_cars = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel_purch.SuspendLayout();
            this.SuspendLayout();
            // 
            // go_to_VehicleType
            // 
            this.go_to_VehicleType.Location = new System.Drawing.Point(12, 29);
            this.go_to_VehicleType.Name = "go_to_VehicleType";
            this.go_to_VehicleType.Size = new System.Drawing.Size(113, 38);
            this.go_to_VehicleType.TabIndex = 0;
            this.go_to_VehicleType.Text = "Catalog";
            this.go_to_VehicleType.UseVisualStyleBackColor = true;
            this.go_to_VehicleType.Click += new System.EventHandler(this.go_to_VehicleType_Click);
            // 
            // butt_logout
            // 
            this.butt_logout.Location = new System.Drawing.Point(517, 225);
            this.butt_logout.Name = "butt_logout";
            this.butt_logout.Size = new System.Drawing.Size(68, 27);
            this.butt_logout.TabIndex = 1;
            this.butt_logout.Text = "Log Out";
            this.butt_logout.UseVisualStyleBackColor = true;
            this.butt_logout.Click += new System.EventHandler(this.butt_logout_Click);
            // 
            // butt_Purchase
            // 
            this.butt_Purchase.Location = new System.Drawing.Point(12, 83);
            this.butt_Purchase.Name = "butt_Purchase";
            this.butt_Purchase.Size = new System.Drawing.Size(113, 38);
            this.butt_Purchase.TabIndex = 2;
            this.butt_Purchase.Text = "My Purchase";
            this.butt_Purchase.UseVisualStyleBackColor = true;
            this.butt_Purchase.Click += new System.EventHandler(this.butt_Purchase_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(202, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Hey , ";
            // 
            // panel_purch
            // 
            this.panel_purch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_purch.Controls.Add(this.lbl_time);
            this.panel_purch.Controls.Add(this.lbl_date);
            this.panel_purch.Controls.Add(this.cb_cars);
            this.panel_purch.Controls.Add(this.lbl_amount);
            this.panel_purch.Controls.Add(this.butt_HidePur);
            this.panel_purch.Location = new System.Drawing.Point(315, 9);
            this.panel_purch.Name = "panel_purch";
            this.panel_purch.Size = new System.Drawing.Size(270, 210);
            this.panel_purch.TabIndex = 4;
            this.panel_purch.Visible = false;
            // 
            // butt_HidePur
            // 
            this.butt_HidePur.BackColor = System.Drawing.Color.IndianRed;
            this.butt_HidePur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butt_HidePur.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.butt_HidePur.Location = new System.Drawing.Point(239, 3);
            this.butt_HidePur.Name = "butt_HidePur";
            this.butt_HidePur.Size = new System.Drawing.Size(28, 23);
            this.butt_HidePur.TabIndex = 0;
            this.butt_HidePur.Text = "X";
            this.butt_HidePur.UseVisualStyleBackColor = false;
            this.butt_HidePur.Click += new System.EventHandler(this.butt_HidePur_Click);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(13, 7);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(72, 13);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "My Purchaes:";
            // 
            // cb_cars
            // 
            this.cb_cars.FormattingEnabled = true;
            this.cb_cars.Location = new System.Drawing.Point(77, 30);
            this.cb_cars.Name = "cb_cars";
            this.cb_cars.Size = new System.Drawing.Size(121, 21);
            this.cb_cars.TabIndex = 2;
            this.cb_cars.SelectedIndexChanged += new System.EventHandler(this.cb_cars_SelectedIndexChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(30, 63);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(33, 13);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(30, 87);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(33, 13);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "Time:";
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 264);
            this.Controls.Add(this.panel_purch);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.butt_Purchase);
            this.Controls.Add(this.butt_logout);
            this.Controls.Add(this.go_to_VehicleType);
            this.Name = "UserDashBoard";
            this.Text = "UserDashBoard";
            this.panel_purch.ResumeLayout(false);
            this.panel_purch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_to_VehicleType;
        private System.Windows.Forms.Button butt_logout;
        private System.Windows.Forms.Button butt_Purchase;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel_purch;
        private System.Windows.Forms.Button butt_HidePur;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.ComboBox cb_cars;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
    }
}
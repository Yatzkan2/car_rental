namespace car_rental
{
    partial class UserMng
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
            this.lbl_headr = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersDownList = new System.Windows.Forms.ComboBox();
            this.lbl_Fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.show_Fname = new System.Windows.Forms.TextBox();
            this.show_Lname = new System.Windows.Forms.TextBox();
            this.show_id = new System.Windows.Forms.TextBox();
            this.show_Username = new System.Windows.Forms.TextBox();
            this.show_pass = new System.Windows.Forms.TextBox();
            this.lbl_favcar = new System.Windows.Forms.Label();
            this.show_favcar = new System.Windows.Forms.TextBox();
            this.butt_backmenu = new System.Windows.Forms.Button();
            this.butt_delUser = new System.Windows.Forms.Button();
            this.butt_editUs = new System.Windows.Forms.Button();
            this.butt_restoreUsr = new System.Windows.Forms.Button();
            this.butt_Cancelchng = new System.Windows.Forms.Button();
            this.butt_saveChngs = new System.Windows.Forms.Button();
            this.FavoriteCarIn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_headr
            // 
            this.lbl_headr.AutoSize = true;
            this.lbl_headr.Location = new System.Drawing.Point(258, 9);
            this.lbl_headr.Name = "lbl_headr";
            this.lbl_headr.Size = new System.Drawing.Size(88, 13);
            this.lbl_headr.TabIndex = 0;
            this.lbl_headr.Text = "User Mangement";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(496, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(71, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "User Amount:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(584, 27);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(0, 13);
            this.lbl_amount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users List:";
            // 
            // UsersDownList
            // 
            this.UsersDownList.Location = new System.Drawing.Point(261, 37);
            this.UsersDownList.Name = "UsersDownList";
            this.UsersDownList.Size = new System.Drawing.Size(100, 21);
            this.UsersDownList.TabIndex = 4;
            this.UsersDownList.Text = "User:";
            this.UsersDownList.SelectedIndexChanged += new System.EventHandler(this.UsersDownList_SelectedIndexChanged);
            // 
            // lbl_Fname
            // 
            this.lbl_Fname.AutoSize = true;
            this.lbl_Fname.Location = new System.Drawing.Point(12, 83);
            this.lbl_Fname.Name = "lbl_Fname";
            this.lbl_Fname.Size = new System.Drawing.Size(60, 13);
            this.lbl_Fname.TabIndex = 5;
            this.lbl_Fname.Text = "First Name:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(194, 83);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 6;
            this.lbl_lname.Text = "Last Name:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(419, 83);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Text = "I.D:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(103, 130);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(60, 13);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "UserName:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(314, 130);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password:";
            // 
            // show_Fname
            // 
            this.show_Fname.Location = new System.Drawing.Point(71, 80);
            this.show_Fname.Name = "show_Fname";
            this.show_Fname.ReadOnly = true;
            this.show_Fname.Size = new System.Drawing.Size(100, 20);
            this.show_Fname.TabIndex = 11;
            // 
            // show_Lname
            // 
            this.show_Lname.Location = new System.Drawing.Point(261, 80);
            this.show_Lname.Name = "show_Lname";
            this.show_Lname.ReadOnly = true;
            this.show_Lname.Size = new System.Drawing.Size(100, 20);
            this.show_Lname.TabIndex = 12;
            // 
            // show_id
            // 
            this.show_id.Location = new System.Drawing.Point(448, 80);
            this.show_id.Name = "show_id";
            this.show_id.ReadOnly = true;
            this.show_id.Size = new System.Drawing.Size(100, 20);
            this.show_id.TabIndex = 13;
            // 
            // show_Username
            // 
            this.show_Username.Location = new System.Drawing.Point(169, 127);
            this.show_Username.Name = "show_Username";
            this.show_Username.ReadOnly = true;
            this.show_Username.Size = new System.Drawing.Size(100, 20);
            this.show_Username.TabIndex = 14;
            // 
            // show_pass
            // 
            this.show_pass.Location = new System.Drawing.Point(376, 127);
            this.show_pass.Name = "show_pass";
            this.show_pass.ReadOnly = true;
            this.show_pass.Size = new System.Drawing.Size(100, 20);
            this.show_pass.TabIndex = 15;
            // 
            // lbl_favcar
            // 
            this.lbl_favcar.AutoSize = true;
            this.lbl_favcar.Location = new System.Drawing.Point(199, 172);
            this.lbl_favcar.Name = "lbl_favcar";
            this.lbl_favcar.Size = new System.Drawing.Size(67, 13);
            this.lbl_favcar.TabIndex = 16;
            this.lbl_favcar.Text = "Favorite Car:";
            // 
            // show_favcar
            // 
            this.show_favcar.Location = new System.Drawing.Point(270, 169);
            this.show_favcar.Name = "show_favcar";
            this.show_favcar.ReadOnly = true;
            this.show_favcar.Size = new System.Drawing.Size(100, 20);
            this.show_favcar.TabIndex = 17;
            // 
            // butt_backmenu
            // 
            this.butt_backmenu.Location = new System.Drawing.Point(12, 9);
            this.butt_backmenu.Name = "butt_backmenu";
            this.butt_backmenu.Size = new System.Drawing.Size(96, 23);
            this.butt_backmenu.TabIndex = 18;
            this.butt_backmenu.Text = "back to main";
            this.butt_backmenu.UseVisualStyleBackColor = true;
            this.butt_backmenu.Click += new System.EventHandler(this.butt_backmenu_Click);
            // 
            // butt_delUser
            // 
            this.butt_delUser.Location = new System.Drawing.Point(71, 223);
            this.butt_delUser.Name = "butt_delUser";
            this.butt_delUser.Size = new System.Drawing.Size(111, 23);
            this.butt_delUser.TabIndex = 19;
            this.butt_delUser.Text = "Delete User";
            this.butt_delUser.UseVisualStyleBackColor = true;
            this.butt_delUser.Click += new System.EventHandler(this.butt_delUser_Click);
            // 
            // butt_editUs
            // 
            this.butt_editUs.Location = new System.Drawing.Point(439, 223);
            this.butt_editUs.Name = "butt_editUs";
            this.butt_editUs.Size = new System.Drawing.Size(99, 23);
            this.butt_editUs.TabIndex = 20;
            this.butt_editUs.Text = "Edit User";
            this.butt_editUs.UseVisualStyleBackColor = true;
            this.butt_editUs.Click += new System.EventHandler(this.butt_editUs_Click);
            // 
            // butt_restoreUsr
            // 
            this.butt_restoreUsr.Location = new System.Drawing.Point(263, 223);
            this.butt_restoreUsr.Name = "butt_restoreUsr";
            this.butt_restoreUsr.Size = new System.Drawing.Size(83, 48);
            this.butt_restoreUsr.TabIndex = 22;
            this.butt_restoreUsr.Text = "Restore Last Deleted User ";
            this.butt_restoreUsr.UseVisualStyleBackColor = true;
            this.butt_restoreUsr.Visible = false;
            this.butt_restoreUsr.Click += new System.EventHandler(this.butt_restoreUsr_Click);
            // 
            // butt_Cancelchng
            // 
            this.butt_Cancelchng.Location = new System.Drawing.Point(217, 277);
            this.butt_Cancelchng.Name = "butt_Cancelchng";
            this.butt_Cancelchng.Size = new System.Drawing.Size(82, 46);
            this.butt_Cancelchng.TabIndex = 23;
            this.butt_Cancelchng.Text = "Canel Changes";
            this.butt_Cancelchng.UseVisualStyleBackColor = true;
            this.butt_Cancelchng.Visible = false;
            this.butt_Cancelchng.Click += new System.EventHandler(this.butt_Cancelchng_Click);
            // 
            // butt_saveChngs
            // 
            this.butt_saveChngs.Location = new System.Drawing.Point(317, 277);
            this.butt_saveChngs.Name = "butt_saveChngs";
            this.butt_saveChngs.Size = new System.Drawing.Size(80, 46);
            this.butt_saveChngs.TabIndex = 24;
            this.butt_saveChngs.Text = "Save The Changes";
            this.butt_saveChngs.UseVisualStyleBackColor = true;
            this.butt_saveChngs.Visible = false;
            this.butt_saveChngs.Click += new System.EventHandler(this.butt_saveChngs_Click);
            // 
            // FavoriteCarIn
            // 
            this.FavoriteCarIn.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Mercedes",
            "BMW"});
            this.FavoriteCarIn.Location = new System.Drawing.Point(376, 168);
            this.FavoriteCarIn.Name = "FavoriteCarIn";
            this.FavoriteCarIn.Size = new System.Drawing.Size(100, 21);
            this.FavoriteCarIn.TabIndex = 25;
            this.FavoriteCarIn.Text = "Pick a Car:";
            this.FavoriteCarIn.Visible = false;
            this.FavoriteCarIn.SelectedIndexChanged += new System.EventHandler(this.FavoriteCarIn_SelectedIndexChanged);
            // 
            // UserMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 335);
            this.Controls.Add(this.FavoriteCarIn);
            this.Controls.Add(this.butt_saveChngs);
            this.Controls.Add(this.butt_Cancelchng);
            this.Controls.Add(this.butt_restoreUsr);
            this.Controls.Add(this.butt_editUs);
            this.Controls.Add(this.butt_delUser);
            this.Controls.Add(this.butt_backmenu);
            this.Controls.Add(this.show_favcar);
            this.Controls.Add(this.lbl_favcar);
            this.Controls.Add(this.show_pass);
            this.Controls.Add(this.show_Username);
            this.Controls.Add(this.show_id);
            this.Controls.Add(this.show_Lname);
            this.Controls.Add(this.show_Fname);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_Fname);
            this.Controls.Add(this.UsersDownList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_headr);
            this.Name = "UserMng";
            this.Text = "UserMng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_headr;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UsersDownList;
        private System.Windows.Forms.Label lbl_Fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox show_Fname;
        private System.Windows.Forms.TextBox show_Lname;
        private System.Windows.Forms.TextBox show_id;
        private System.Windows.Forms.TextBox show_Username;
        private System.Windows.Forms.TextBox show_pass;
        private System.Windows.Forms.Label lbl_favcar;
        private System.Windows.Forms.TextBox show_favcar;
        private System.Windows.Forms.Button butt_backmenu;
        private System.Windows.Forms.Button butt_delUser;
        private System.Windows.Forms.Button butt_editUs;
        private System.Windows.Forms.Button butt_restoreUsr;
        private System.Windows.Forms.Button butt_Cancelchng;
        private System.Windows.Forms.Button butt_saveChngs;
        private System.Windows.Forms.ComboBox FavoriteCarIn;
    }
}
using System.Drawing.Text;
using System.Net.Http.Headers;

namespace car_rental
{
    partial class Registration
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.input_Fname = new System.Windows.Forms.TextBox();
            this.lbl_Firstname = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.input_Lname = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.input_ID = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.input_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.input_Password = new System.Windows.Forms.TextBox();
            this.lbl_favCar = new System.Windows.Forms.Label();
            this.butt_Register = new System.Windows.Forms.Button();
            this.FavoriteCarIn = new System.Windows.Forms.ComboBox();
            this.butt_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(208, 29);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(63, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Registration";
            // 
            // input_Fname
            // 
            this.input_Fname.Location = new System.Drawing.Point(116, 70);
            this.input_Fname.Name = "input_Fname";
            this.input_Fname.Size = new System.Drawing.Size(100, 20);
            this.input_Fname.TabIndex = 1;
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Location = new System.Drawing.Point(50, 73);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(60, 13);
            this.lbl_Firstname.TabIndex = 2;
            this.lbl_Firstname.Text = "First Name:";
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Location = new System.Drawing.Point(50, 110);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(64, 13);
            this.lbl_Lname.TabIndex = 3;
            this.lbl_Lname.Text = "Last Name :";
            // 
            // input_Lname
            // 
            this.input_Lname.Location = new System.Drawing.Point(116, 107);
            this.input_Lname.Name = "input_Lname";
            this.input_Lname.Size = new System.Drawing.Size(100, 20);
            this.input_Lname.TabIndex = 4;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(47, 149);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(67, 13);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "I.D Number :";
            // 
            // input_ID
            // 
            this.input_ID.Location = new System.Drawing.Point(116, 146);
            this.input_ID.Name = "input_ID";
            this.input_ID.Size = new System.Drawing.Size(100, 20);
            this.input_ID.TabIndex = 6;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(270, 70);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(60, 13);
            this.lbl_User.TabIndex = 7;
            this.lbl_User.Text = "UserName:";
            // 
            // input_UserName
            // 
            this.input_UserName.Location = new System.Drawing.Point(336, 66);
            this.input_UserName.Name = "input_UserName";
            this.input_UserName.Size = new System.Drawing.Size(114, 20);
            this.input_UserName.TabIndex = 8;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(274, 110);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password:";
            // 
            // input_Password
            // 
            this.input_Password.Location = new System.Drawing.Point(336, 107);
            this.input_Password.Name = "input_Password";
            this.input_Password.Size = new System.Drawing.Size(114, 20);
            this.input_Password.TabIndex = 10;
            // 
            // lbl_favCar
            // 
            this.lbl_favCar.AutoSize = true;
            this.lbl_favCar.Location = new System.Drawing.Point(263, 146);
            this.lbl_favCar.Name = "lbl_favCar";
            this.lbl_favCar.Size = new System.Drawing.Size(67, 13);
            this.lbl_favCar.TabIndex = 11;
            this.lbl_favCar.Text = "Favorite Car:";
            // 
            // butt_Register
            // 
            this.butt_Register.Location = new System.Drawing.Point(211, 196);
            this.butt_Register.Name = "butt_Register";
            this.butt_Register.Size = new System.Drawing.Size(85, 32);
            this.butt_Register.TabIndex = 12;
            this.butt_Register.Text = "Register";
            this.butt_Register.UseVisualStyleBackColor = true;
            this.butt_Register.Click += new System.EventHandler(this.butt_Register_Click_1);
            // 
            // FavoriteCarIn
            // 
            this.FavoriteCarIn.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Mercedes",
            "BMW"});
            this.FavoriteCarIn.Location = new System.Drawing.Point(353, 141);
            this.FavoriteCarIn.Name = "FavoriteCarIn";
            this.FavoriteCarIn.Size = new System.Drawing.Size(100, 21);
            this.FavoriteCarIn.TabIndex = 0;
            this.FavoriteCarIn.Text = "Company:";
            this.FavoriteCarIn.DropDown += new System.EventHandler(this.FavoriteCarIN_DropDown);
            this.FavoriteCarIn.SelectedIndexChanged += new System.EventHandler(this.FavoriteCarIn_SelectedIndexChanged);
            // 
            // butt_Back
            // 
            this.butt_Back.Location = new System.Drawing.Point(12, 12);
            this.butt_Back.Name = "butt_Back";
            this.butt_Back.Size = new System.Drawing.Size(53, 23);
            this.butt_Back.TabIndex = 13;
            this.butt_Back.Text = "Back";
            this.butt_Back.UseVisualStyleBackColor = true;
            this.butt_Back.Click += new System.EventHandler(this.butt_Back_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::car_rental.Properties.Resources.RedLambo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 259);
            this.Controls.Add(this.butt_Back);
            this.Controls.Add(this.FavoriteCarIn);
            this.Controls.Add(this.butt_Register);
            this.Controls.Add(this.lbl_favCar);
            this.Controls.Add(this.input_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.input_UserName);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.input_ID);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.input_Lname);
            this.Controls.Add(this.lbl_Lname);
            this.Controls.Add(this.lbl_Firstname);
            this.Controls.Add(this.input_Fname);
            this.Controls.Add(this.lbl_title);
            this.Name = "Registration";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void FavoriteCarIN_DropDown(object sender,System.EventArgs e)
        {
           
       
        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox input_Fname;
        private System.Windows.Forms.Label lbl_Firstname;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.TextBox input_Lname;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox input_ID;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox input_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox input_Password;
        private System.Windows.Forms.Label lbl_favCar;
        private System.Windows.Forms.Button butt_Register;
        private System.Windows.Forms.ComboBox FavoriteCarIn;
        private System.Windows.Forms.Button butt_Back;
    }
}
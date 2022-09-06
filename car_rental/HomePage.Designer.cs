namespace car_rental
{
    partial class HomePage
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
            this.butt_Reg = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.Label();
            this.userName_input = new System.Windows.Forms.TextBox();
            this.is_password_visible = new System.Windows.Forms.Button();
            this.lable_password = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.butt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butt_Reg
            // 
            this.butt_Reg.Location = new System.Drawing.Point(246, 32);
            this.butt_Reg.Name = "butt_Reg";
            this.butt_Reg.Size = new System.Drawing.Size(75, 23);
            this.butt_Reg.TabIndex = 13;
            this.butt_Reg.Text = "Register";
            this.butt_Reg.UseVisualStyleBackColor = true;
            this.butt_Reg.Click += new System.EventHandler(this.butt_Reg_Click);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(18, 37);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(60, 13);
            this.user_name.TabIndex = 12;
            this.user_name.Text = "User Name";
            // 
            // userName_input
            // 
            this.userName_input.Location = new System.Drawing.Point(84, 34);
            this.userName_input.Name = "userName_input";
            this.userName_input.Size = new System.Drawing.Size(138, 20);
            this.userName_input.TabIndex = 11;
            // 
            // is_password_visible
            // 
            this.is_password_visible.Location = new System.Drawing.Point(228, 66);
            this.is_password_visible.Name = "is_password_visible";
            this.is_password_visible.Size = new System.Drawing.Size(111, 22);
            this.is_password_visible.TabIndex = 10;
            this.is_password_visible.Text = "Show Password";
            this.is_password_visible.UseVisualStyleBackColor = true;
            this.is_password_visible.Click += new System.EventHandler(this.is_password_visible_Click);
            // 
            // lable_password
            // 
            this.lable_password.AutoSize = true;
            this.lable_password.Location = new System.Drawing.Point(18, 71);
            this.lable_password.Name = "lable_password";
            this.lable_password.Size = new System.Drawing.Size(56, 13);
            this.lable_password.TabIndex = 9;
            this.lable_password.Text = "Password:";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(84, 68);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(138, 20);
            this.password_input.TabIndex = 8;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // butt_login
            // 
            this.butt_login.Location = new System.Drawing.Point(49, 94);
            this.butt_login.Name = "butt_login";
            this.butt_login.Size = new System.Drawing.Size(173, 27);
            this.butt_login.TabIndex = 7;
            this.butt_login.Text = "Login";
            this.butt_login.UseVisualStyleBackColor = true;
            this.butt_login.Click += new System.EventHandler(this.butt_login_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::car_rental.Properties.Resources.AlfaGuilia;
            this.ClientSize = new System.Drawing.Size(481, 306);
            this.Controls.Add(this.butt_Reg);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.userName_input);
            this.Controls.Add(this.is_password_visible);
            this.Controls.Add(this.lable_password);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.butt_login);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_Reg;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.TextBox userName_input;
        private System.Windows.Forms.Button is_password_visible;
        private System.Windows.Forms.Label lable_password;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button butt_login;
    }
}
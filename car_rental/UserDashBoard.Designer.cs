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
            this.SuspendLayout();
            // 
            // go_to_VehicleType
            // 
            this.go_to_VehicleType.Location = new System.Drawing.Point(130, 194);
            this.go_to_VehicleType.Name = "go_to_VehicleType";
            this.go_to_VehicleType.Size = new System.Drawing.Size(136, 51);
            this.go_to_VehicleType.TabIndex = 0;
            this.go_to_VehicleType.Text = "Catalog";
            this.go_to_VehicleType.UseVisualStyleBackColor = true;
            this.go_to_VehicleType.Click += new System.EventHandler(this.go_to_VehicleType_Click);
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go_to_VehicleType);
            this.Name = "UserDashBoard";
            this.Text = "UserDashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_to_VehicleType;
    }
}
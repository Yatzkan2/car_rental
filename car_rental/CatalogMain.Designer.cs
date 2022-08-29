namespace car_rental
{
    partial class CatalogMain
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
            this.go_to_AllVehicle = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_to_VehicleType
            // 
            this.go_to_VehicleType.Location = new System.Drawing.Point(170, 217);
            this.go_to_VehicleType.Name = "go_to_VehicleType";
            this.go_to_VehicleType.Size = new System.Drawing.Size(110, 23);
            this.go_to_VehicleType.TabIndex = 0;
            this.go_to_VehicleType.Text = "Custom Choice";
            this.go_to_VehicleType.UseVisualStyleBackColor = true;
            this.go_to_VehicleType.Click += new System.EventHandler(this.go_to_VehicleType_Click);
            // 
            // go_to_AllVehicle
            // 
            this.go_to_AllVehicle.Location = new System.Drawing.Point(542, 217);
            this.go_to_AllVehicle.Name = "go_to_AllVehicle";
            this.go_to_AllVehicle.Size = new System.Drawing.Size(75, 23);
            this.go_to_AllVehicle.TabIndex = 1;
            this.go_to_AllVehicle.Text = "All Vehicles";
            this.go_to_AllVehicle.UseVisualStyleBackColor = true;
            this.go_to_AllVehicle.Click += new System.EventHandler(this.go_to_AllVehicle_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(1, 1);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // CatalogMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.go_to_AllVehicle);
            this.Controls.Add(this.go_to_VehicleType);
            this.Name = "CatalogMain";
            this.Text = "CatalogMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_to_VehicleType;
        private System.Windows.Forms.Button go_to_AllVehicle;
        private System.Windows.Forms.Button back_button;
    }
}
namespace car_rental
{
    partial class VehicleType
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
            this.go_to_MotorcycleCatalog = new System.Windows.Forms.Button();
            this.go_to_PrivateCarCatalog = new System.Windows.Forms.Button();
            this.go_to_CargoCatalog = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_to_MotorcycleCatalog
            // 
            this.go_to_MotorcycleCatalog.Location = new System.Drawing.Point(118, 178);
            this.go_to_MotorcycleCatalog.Name = "go_to_MotorcycleCatalog";
            this.go_to_MotorcycleCatalog.Size = new System.Drawing.Size(75, 23);
            this.go_to_MotorcycleCatalog.TabIndex = 0;
            this.go_to_MotorcycleCatalog.Text = "Motorcycle";
            this.go_to_MotorcycleCatalog.UseVisualStyleBackColor = true;
            this.go_to_MotorcycleCatalog.Click += new System.EventHandler(this.go_to_MotorcycleCatalog_Click);
            // 
            // go_to_PrivateCarCatalog
            // 
            this.go_to_PrivateCarCatalog.Location = new System.Drawing.Point(331, 178);
            this.go_to_PrivateCarCatalog.Name = "go_to_PrivateCarCatalog";
            this.go_to_PrivateCarCatalog.Size = new System.Drawing.Size(91, 23);
            this.go_to_PrivateCarCatalog.TabIndex = 1;
            this.go_to_PrivateCarCatalog.Text = "Private Car";
            this.go_to_PrivateCarCatalog.UseVisualStyleBackColor = true;
            this.go_to_PrivateCarCatalog.Click += new System.EventHandler(this.go_to_PrivateCarCAtalog_Click);
            // 
            // go_to_CargoCatalog
            // 
            this.go_to_CargoCatalog.Location = new System.Drawing.Point(522, 178);
            this.go_to_CargoCatalog.Name = "go_to_CargoCatalog";
            this.go_to_CargoCatalog.Size = new System.Drawing.Size(75, 23);
            this.go_to_CargoCatalog.TabIndex = 2;
            this.go_to_CargoCatalog.Text = "Cargo";
            this.go_to_CargoCatalog.UseVisualStyleBackColor = true;
            this.go_to_CargoCatalog.Click += new System.EventHandler(this.go_to_CargoCatalog_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(-1, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // VehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.go_to_CargoCatalog);
            this.Controls.Add(this.go_to_PrivateCarCatalog);
            this.Controls.Add(this.go_to_MotorcycleCatalog);
            this.Name = "VehicleType";
            this.Text = "GasolineVehicleType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_to_MotorcycleCatalog;
        private System.Windows.Forms.Button go_to_PrivateCarCatalog;
        private System.Windows.Forms.Button go_to_CargoCatalog;
        private System.Windows.Forms.Button back_button;
    }
}
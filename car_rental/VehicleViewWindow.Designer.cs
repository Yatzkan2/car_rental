namespace car_rental
{
    partial class VehicleViewWindow
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
            this.flowLayoutPanel_technicalDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.model = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.gear = new System.Windows.Forms.Label();
            this.engine_capcity = new System.Windows.Forms.Label();
            this.fuel_tank_capacity = new System.Windows.Forms.Label();
            this.fuel_consumption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_technicalDetails
            // 
            this.flowLayoutPanel_technicalDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_technicalDetails.Location = new System.Drawing.Point(21, 54);
            this.flowLayoutPanel_technicalDetails.Name = "flowLayoutPanel_technicalDetails";
            this.flowLayoutPanel_technicalDetails.Size = new System.Drawing.Size(215, 369);
            this.flowLayoutPanel_technicalDetails.TabIndex = 0;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(276, 112);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 0;
            this.model.Text = "Model";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(276, 156);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 13);
            this.color.TabIndex = 1;
            this.color.Text = "Color";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(276, 197);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(29, 13);
            this.year.TabIndex = 2;
            this.year.Text = "Year";
            // 
            // gear
            // 
            this.gear.AutoSize = true;
            this.gear.Location = new System.Drawing.Point(385, 112);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(30, 13);
            this.gear.TabIndex = 1;
            this.gear.Text = "Gear";
            this.gear.Visible = false;
            // 
            // engine_capcity
            // 
            this.engine_capcity.AutoSize = true;
            this.engine_capcity.Location = new System.Drawing.Point(384, 156);
            this.engine_capcity.Name = "engine_capcity";
            this.engine_capcity.Size = new System.Drawing.Size(83, 13);
            this.engine_capcity.TabIndex = 2;
            this.engine_capcity.Text = "Engine capacity";
            this.engine_capcity.Visible = false;
            // 
            // fuel_tank_capacity
            // 
            this.fuel_tank_capacity.AutoSize = true;
            this.fuel_tank_capacity.Location = new System.Drawing.Point(382, 241);
            this.fuel_tank_capacity.Name = "fuel_tank_capacity";
            this.fuel_tank_capacity.Size = new System.Drawing.Size(94, 13);
            this.fuel_tank_capacity.TabIndex = 4;
            this.fuel_tank_capacity.Text = "Fuel tank capacity";
            this.fuel_tank_capacity.Visible = false;
            // 
            // fuel_consumption
            // 
            this.fuel_consumption.AutoSize = true;
            this.fuel_consumption.Location = new System.Drawing.Point(383, 197);
            this.fuel_consumption.Name = "fuel_consumption";
            this.fuel_consumption.Size = new System.Drawing.Size(90, 13);
            this.fuel_consumption.TabIndex = 3;
            this.fuel_consumption.Text = "Fuel consumption";
            this.fuel_consumption.Visible = false;
            // 
            // VehicleViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.color);
            this.Controls.Add(this.model);
            this.Controls.Add(this.fuel_tank_capacity);
            this.Controls.Add(this.fuel_consumption);
            this.Controls.Add(this.engine_capcity);
            this.Controls.Add(this.gear);
            this.Controls.Add(this.flowLayoutPanel_technicalDetails);
            this.Name = "VehicleViewWindow";
            this.Text = "vehicle details";
            this.Load += new System.EventHandler(this.VehicleViewWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_technicalDetails;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.Label engine_capcity;
        private System.Windows.Forms.Label fuel_tank_capacity;
        private System.Windows.Forms.Label fuel_consumption;
    }
}
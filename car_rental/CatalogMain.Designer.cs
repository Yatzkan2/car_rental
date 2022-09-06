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
            this.back_button = new System.Windows.Forms.Button();
            this.open_motorcycle_view = new System.Windows.Forms.RadioButton();
            this.open_groupBox_pricvate_car = new System.Windows.Forms.RadioButton();
            this.open_cargo_view = new System.Windows.Forms.RadioButton();
            this.open_gasoline_private_car_view = new System.Windows.Forms.RadioButton();
            this.open_elc_private_car_view = new System.Windows.Forms.RadioButton();
            this.open_all_private_car_view = new System.Windows.Forms.RadioButton();
            this.groupBoxPrivateCar = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelVehicleButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxPrivateCar.SuspendLayout();
            this.SuspendLayout();
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
            // open_motorcycle_view
            // 
            this.open_motorcycle_view.AutoSize = true;
            this.open_motorcycle_view.Location = new System.Drawing.Point(343, 40);
            this.open_motorcycle_view.Name = "open_motorcycle_view";
            this.open_motorcycle_view.Size = new System.Drawing.Size(77, 17);
            this.open_motorcycle_view.TabIndex = 3;
            this.open_motorcycle_view.TabStop = true;
            this.open_motorcycle_view.Text = "Motorcycle";
            this.open_motorcycle_view.UseVisualStyleBackColor = true;
            this.open_motorcycle_view.CheckedChanged += new System.EventHandler(this.open_motorcycle_view_CheckedChanged);
            // 
            // open_groupBox_pricvate_car
            // 
            this.open_groupBox_pricvate_car.AutoSize = true;
            this.open_groupBox_pricvate_car.Location = new System.Drawing.Point(89, 40);
            this.open_groupBox_pricvate_car.Name = "open_groupBox_pricvate_car";
            this.open_groupBox_pricvate_car.Size = new System.Drawing.Size(58, 17);
            this.open_groupBox_pricvate_car.TabIndex = 4;
            this.open_groupBox_pricvate_car.TabStop = true;
            this.open_groupBox_pricvate_car.Text = "Private";
            this.open_groupBox_pricvate_car.UseVisualStyleBackColor = true;
            this.open_groupBox_pricvate_car.CheckedChanged += new System.EventHandler(this.open_groupBox_pricvate_car_CheckedChanged);
            // 
            // open_cargo_view
            // 
            this.open_cargo_view.AutoSize = true;
            this.open_cargo_view.Location = new System.Drawing.Point(588, 40);
            this.open_cargo_view.Name = "open_cargo_view";
            this.open_cargo_view.Size = new System.Drawing.Size(53, 17);
            this.open_cargo_view.TabIndex = 6;
            this.open_cargo_view.TabStop = true;
            this.open_cargo_view.Text = "Cargo";
            this.open_cargo_view.UseVisualStyleBackColor = true;
            this.open_cargo_view.CheckedChanged += new System.EventHandler(this.open_cargo_view_CheckedChanged);
            // 
            // open_gasoline_private_car_view
            // 
            this.open_gasoline_private_car_view.AutoSize = true;
            this.open_gasoline_private_car_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.open_gasoline_private_car_view.Location = new System.Drawing.Point(16, 23);
            this.open_gasoline_private_car_view.Name = "open_gasoline_private_car_view";
            this.open_gasoline_private_car_view.Size = new System.Drawing.Size(47, 17);
            this.open_gasoline_private_car_view.TabIndex = 5;
            this.open_gasoline_private_car_view.TabStop = true;
            this.open_gasoline_private_car_view.Text = "Gas";
            this.open_gasoline_private_car_view.UseVisualStyleBackColor = true;
            this.open_gasoline_private_car_view.CheckedChanged += new System.EventHandler(this.open_gasoline_private_car_view_CheckedChanged);
            // 
            // open_elc_private_car_view
            // 
            this.open_elc_private_car_view.AutoSize = true;
            this.open_elc_private_car_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.open_elc_private_car_view.Location = new System.Drawing.Point(16, 46);
            this.open_elc_private_car_view.Name = "open_elc_private_car_view";
            this.open_elc_private_car_view.Size = new System.Drawing.Size(68, 17);
            this.open_elc_private_car_view.TabIndex = 8;
            this.open_elc_private_car_view.TabStop = true;
            this.open_elc_private_car_view.Text = "Electric";
            this.open_elc_private_car_view.UseVisualStyleBackColor = true;
            this.open_elc_private_car_view.CheckedChanged += new System.EventHandler(this.open_elc_private_car_view_CheckedChanged);
            // 
            // open_all_private_car_view
            // 
            this.open_all_private_car_view.AutoSize = true;
            this.open_all_private_car_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.open_all_private_car_view.Location = new System.Drawing.Point(16, 69);
            this.open_all_private_car_view.Name = "open_all_private_car_view";
            this.open_all_private_car_view.Size = new System.Drawing.Size(39, 17);
            this.open_all_private_car_view.TabIndex = 7;
            this.open_all_private_car_view.TabStop = true;
            this.open_all_private_car_view.Text = "All";
            this.open_all_private_car_view.UseVisualStyleBackColor = true;
            this.open_all_private_car_view.CheckedChanged += new System.EventHandler(this.open_all_private_car_view_CheckedChanged);
            // 
            // groupBoxPrivateCar
            // 
            this.groupBoxPrivateCar.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPrivateCar.Controls.Add(this.open_elc_private_car_view);
            this.groupBoxPrivateCar.Controls.Add(this.open_gasoline_private_car_view);
            this.groupBoxPrivateCar.Controls.Add(this.open_all_private_car_view);
            this.groupBoxPrivateCar.Location = new System.Drawing.Point(47, 74);
            this.groupBoxPrivateCar.Name = "groupBoxPrivateCar";
            this.groupBoxPrivateCar.Size = new System.Drawing.Size(100, 96);
            this.groupBoxPrivateCar.TabIndex = 9;
            this.groupBoxPrivateCar.TabStop = false;
            this.groupBoxPrivateCar.Visible = false;
            // 
            // flowLayoutPanelVehicleButtons
            // 
            this.flowLayoutPanelVehicleButtons.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelVehicleButtons.Location = new System.Drawing.Point(47, 176);
            this.flowLayoutPanelVehicleButtons.Name = "flowLayoutPanelVehicleButtons";
            this.flowLayoutPanelVehicleButtons.Size = new System.Drawing.Size(686, 214);
            this.flowLayoutPanelVehicleButtons.TabIndex = 10;
            // 
            // CatalogMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::car_rental.Properties.Resources.AlfaGuiliaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 420);
            this.Controls.Add(this.flowLayoutPanelVehicleButtons);
            this.Controls.Add(this.groupBoxPrivateCar);
            this.Controls.Add(this.open_cargo_view);
            this.Controls.Add(this.open_groupBox_pricvate_car);
            this.Controls.Add(this.open_motorcycle_view);
            this.Controls.Add(this.back_button);
            this.Name = "CatalogMain";
            this.Text = "CatalogMain";
            this.groupBoxPrivateCar.ResumeLayout(false);
            this.groupBoxPrivateCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.RadioButton open_motorcycle_view;
        private System.Windows.Forms.RadioButton open_groupBox_pricvate_car;
        private System.Windows.Forms.RadioButton open_cargo_view;
        private System.Windows.Forms.RadioButton open_gasoline_private_car_view;
        private System.Windows.Forms.RadioButton open_elc_private_car_view;
        private System.Windows.Forms.RadioButton open_all_private_car_view;
        private System.Windows.Forms.GroupBox groupBoxPrivateCar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVehicleButtons;
    }
}
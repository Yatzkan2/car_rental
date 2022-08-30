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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.open_cargo_view = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelVehicleButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
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
            this.open_motorcycle_view.Location = new System.Drawing.Point(105, 51);
            this.open_motorcycle_view.Name = "open_motorcycle_view";
            this.open_motorcycle_view.Size = new System.Drawing.Size(77, 17);
            this.open_motorcycle_view.TabIndex = 3;
            this.open_motorcycle_view.TabStop = true;
            this.open_motorcycle_view.Text = "Motorcycle";
            this.open_motorcycle_view.UseVisualStyleBackColor = true;
            this.open_motorcycle_view.CheckedChanged += new System.EventHandler(this.open_motorcycle_view_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(324, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // open_cargo_view
            // 
            this.open_cargo_view.AutoSize = true;
            this.open_cargo_view.Location = new System.Drawing.Point(572, 51);
            this.open_cargo_view.Name = "open_cargo_view";
            this.open_cargo_view.Size = new System.Drawing.Size(53, 17);
            this.open_cargo_view.TabIndex = 6;
            this.open_cargo_view.TabStop = true;
            this.open_cargo_view.Text = "Cargo";
            this.open_cargo_view.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 46);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 69);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(295, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // flowLayoutPanelVehicleButtons
            // 
            this.flowLayoutPanelVehicleButtons.Location = new System.Drawing.Point(12, 264);
            this.flowLayoutPanelVehicleButtons.Name = "flowLayoutPanelVehicleButtons";
            this.flowLayoutPanelVehicleButtons.Size = new System.Drawing.Size(776, 306);
            this.flowLayoutPanelVehicleButtons.TabIndex = 10;
            // 
            // CatalogMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.flowLayoutPanelVehicleButtons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.open_cargo_view);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.open_motorcycle_view);
            this.Controls.Add(this.back_button);
            this.Name = "CatalogMain";
            this.Text = "CatalogMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.RadioButton open_motorcycle_view;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton open_cargo_view;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVehicleButtons;
    }
}
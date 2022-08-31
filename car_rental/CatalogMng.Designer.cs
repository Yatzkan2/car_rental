namespace car_rental
{
    partial class CatalogMng
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
            this.butt_gotoadmn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butt_gotoadmn
            // 
            this.butt_gotoadmn.Location = new System.Drawing.Point(12, 12);
            this.butt_gotoadmn.Name = "butt_gotoadmn";
            this.butt_gotoadmn.Size = new System.Drawing.Size(75, 23);
            this.butt_gotoadmn.TabIndex = 0;
            this.butt_gotoadmn.Text = "Back";
            this.butt_gotoadmn.UseVisualStyleBackColor = true;
            this.butt_gotoadmn.Click += new System.EventHandler(this.butt_gotoadmn_Click);
            // 
            // CatalogMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_gotoadmn);
            this.Name = "CatalogMng";
            this.Text = "CatalogMng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_gotoadmn;
    }
}
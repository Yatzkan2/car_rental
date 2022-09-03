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
            this.butt_addnew = new System.Windows.Forms.Button();
            this.butt_editstock = new System.Windows.Forms.Button();
            this.input_engineCap = new System.Windows.Forms.Panel();
            this.lbl_addnew = new System.Windows.Forms.Label();
            this.lbl_vecType = new System.Windows.Forms.Label();
            this.rdButt_Private = new System.Windows.Forms.RadioButton();
            this.rdbutt_Motor = new System.Windows.Forms.RadioButton();
            this.rdbutt_Cargo = new System.Windows.Forms.RadioButton();
            this.cb_enigneType = new System.Windows.Forms.ComboBox();
            this.lbl_engineType = new System.Windows.Forms.Label();
            this.cb_Companies = new System.Windows.Forms.ComboBox();
            this.lbl_company = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_Model = new System.Windows.Forms.TextBox();
            this.chkBox_Auto = new System.Windows.Forms.CheckBox();
            this.chkBox_Manual = new System.Windows.Forms.CheckBox();
            this.lbl_gear = new System.Windows.Forms.Label();
            this.lbl_engineCap = new System.Windows.Forms.Label();
            this.input_enigneCapa = new System.Windows.Forms.TextBox();
            this.lbl_bodyType = new System.Windows.Forms.Label();
            this.cb_bodyType = new System.Windows.Forms.ComboBox();
            this.lbl_FuelTank = new System.Windows.Forms.Label();
            this.input_fuelCap = new System.Windows.Forms.TextBox();
            this.lbl_fuelCuns = new System.Windows.Forms.Label();
            this.input_fuelCons = new System.Windows.Forms.TextBox();
            this.lbl_manuyear = new System.Windows.Forms.Label();
            this.cb_manuYear = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.input_weight = new System.Windows.Forms.TextBox();
            this.lbl_wheelSize = new System.Windows.Forms.Label();
            this.input_wheelSize = new System.Windows.Forms.TextBox();
            this.lbl_maxspeed = new System.Windows.Forms.Label();
            this.input_maxspeed = new System.Windows.Forms.TextBox();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.input_Accele = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.input_color = new System.Windows.Forms.TextBox();
            this.lbl_liencePlate = new System.Windows.Forms.Label();
            this.input_liecenePl = new System.Windows.Forms.TextBox();
            this.butt_saveCar = new System.Windows.Forms.Button();
            this.lbl_highet = new System.Windows.Forms.Label();
            this.input_highet = new System.Windows.Forms.TextBox();
            this.lbl_length = new System.Windows.Forms.Label();
            this.input_length = new System.Windows.Forms.TextBox();
            this.input_engineCap.SuspendLayout();
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
            // butt_addnew
            // 
            this.butt_addnew.Location = new System.Drawing.Point(12, 57);
            this.butt_addnew.Name = "butt_addnew";
            this.butt_addnew.Size = new System.Drawing.Size(129, 46);
            this.butt_addnew.TabIndex = 1;
            this.butt_addnew.Text = "Add New Veichle";
            this.butt_addnew.UseVisualStyleBackColor = true;
            this.butt_addnew.Click += new System.EventHandler(this.butt_addnew_Click);
            // 
            // butt_editstock
            // 
            this.butt_editstock.Location = new System.Drawing.Point(12, 124);
            this.butt_editstock.Name = "butt_editstock";
            this.butt_editstock.Size = new System.Drawing.Size(129, 46);
            this.butt_editstock.TabIndex = 2;
            this.butt_editstock.Text = "Edit Current Stock";
            this.butt_editstock.UseVisualStyleBackColor = true;
            this.butt_editstock.Click += new System.EventHandler(this.butt_editstock_Click);
            // 
            // input_engineCap
            // 
            this.input_engineCap.Controls.Add(this.input_length);
            this.input_engineCap.Controls.Add(this.lbl_length);
            this.input_engineCap.Controls.Add(this.input_highet);
            this.input_engineCap.Controls.Add(this.lbl_highet);
            this.input_engineCap.Controls.Add(this.butt_saveCar);
            this.input_engineCap.Controls.Add(this.input_liecenePl);
            this.input_engineCap.Controls.Add(this.lbl_liencePlate);
            this.input_engineCap.Controls.Add(this.input_color);
            this.input_engineCap.Controls.Add(this.lbl_color);
            this.input_engineCap.Controls.Add(this.input_Accele);
            this.input_engineCap.Controls.Add(this.lbl_acc);
            this.input_engineCap.Controls.Add(this.input_maxspeed);
            this.input_engineCap.Controls.Add(this.lbl_maxspeed);
            this.input_engineCap.Controls.Add(this.input_wheelSize);
            this.input_engineCap.Controls.Add(this.lbl_wheelSize);
            this.input_engineCap.Controls.Add(this.input_weight);
            this.input_engineCap.Controls.Add(this.lbl_Weight);
            this.input_engineCap.Controls.Add(this.cb_manuYear);
            this.input_engineCap.Controls.Add(this.lbl_manuyear);
            this.input_engineCap.Controls.Add(this.input_fuelCons);
            this.input_engineCap.Controls.Add(this.lbl_fuelCuns);
            this.input_engineCap.Controls.Add(this.input_fuelCap);
            this.input_engineCap.Controls.Add(this.lbl_FuelTank);
            this.input_engineCap.Controls.Add(this.cb_bodyType);
            this.input_engineCap.Controls.Add(this.lbl_bodyType);
            this.input_engineCap.Controls.Add(this.input_enigneCapa);
            this.input_engineCap.Controls.Add(this.lbl_engineCap);
            this.input_engineCap.Controls.Add(this.lbl_gear);
            this.input_engineCap.Controls.Add(this.chkBox_Manual);
            this.input_engineCap.Controls.Add(this.chkBox_Auto);
            this.input_engineCap.Controls.Add(this.input_Model);
            this.input_engineCap.Controls.Add(this.label1);
            this.input_engineCap.Controls.Add(this.lbl_company);
            this.input_engineCap.Controls.Add(this.cb_Companies);
            this.input_engineCap.Controls.Add(this.lbl_engineType);
            this.input_engineCap.Controls.Add(this.cb_enigneType);
            this.input_engineCap.Controls.Add(this.rdbutt_Cargo);
            this.input_engineCap.Controls.Add(this.rdbutt_Motor);
            this.input_engineCap.Controls.Add(this.rdButt_Private);
            this.input_engineCap.Controls.Add(this.lbl_vecType);
            this.input_engineCap.Controls.Add(this.lbl_addnew);
            this.input_engineCap.Location = new System.Drawing.Point(192, 12);
            this.input_engineCap.Name = "input_engineCap";
            this.input_engineCap.Size = new System.Drawing.Size(576, 393);
            this.input_engineCap.TabIndex = 3;
            this.input_engineCap.Visible = false;
            // 
            // lbl_addnew
            // 
            this.lbl_addnew.AutoSize = true;
            this.lbl_addnew.Location = new System.Drawing.Point(245, 10);
            this.lbl_addnew.Name = "lbl_addnew";
            this.lbl_addnew.Size = new System.Drawing.Size(71, 13);
            this.lbl_addnew.TabIndex = 0;
            this.lbl_addnew.Text = "Add new Car:";
            // 
            // lbl_vecType
            // 
            this.lbl_vecType.AutoSize = true;
            this.lbl_vecType.Location = new System.Drawing.Point(12, 28);
            this.lbl_vecType.Name = "lbl_vecType";
            this.lbl_vecType.Size = new System.Drawing.Size(96, 13);
            this.lbl_vecType.TabIndex = 1;
            this.lbl_vecType.Text = "Pick Veichle Type:";
            // 
            // rdButt_Private
            // 
            this.rdButt_Private.AutoSize = true;
            this.rdButt_Private.Location = new System.Drawing.Point(124, 28);
            this.rdButt_Private.Name = "rdButt_Private";
            this.rdButt_Private.Size = new System.Drawing.Size(77, 17);
            this.rdButt_Private.TabIndex = 2;
            this.rdButt_Private.TabStop = true;
            this.rdButt_Private.Text = "Private Car";
            this.rdButt_Private.UseVisualStyleBackColor = true;
            this.rdButt_Private.CheckedChanged += new System.EventHandler(this.rdButt_Private_CheckedChanged);
            // 
            // rdbutt_Motor
            // 
            this.rdbutt_Motor.AutoSize = true;
            this.rdbutt_Motor.Location = new System.Drawing.Point(259, 28);
            this.rdbutt_Motor.Name = "rdbutt_Motor";
            this.rdbutt_Motor.Size = new System.Drawing.Size(78, 17);
            this.rdbutt_Motor.TabIndex = 3;
            this.rdbutt_Motor.TabStop = true;
            this.rdbutt_Motor.Text = "MotorCycle";
            this.rdbutt_Motor.UseVisualStyleBackColor = true;
            this.rdbutt_Motor.CheckedChanged += new System.EventHandler(this.rdbutt_Motor_CheckedChanged);
            // 
            // rdbutt_Cargo
            // 
            this.rdbutt_Cargo.AutoSize = true;
            this.rdbutt_Cargo.Location = new System.Drawing.Point(430, 28);
            this.rdbutt_Cargo.Name = "rdbutt_Cargo";
            this.rdbutt_Cargo.Size = new System.Drawing.Size(53, 17);
            this.rdbutt_Cargo.TabIndex = 4;
            this.rdbutt_Cargo.TabStop = true;
            this.rdbutt_Cargo.Text = "Cargo";
            this.rdbutt_Cargo.UseVisualStyleBackColor = true;
            this.rdbutt_Cargo.CheckedChanged += new System.EventHandler(this.rdbutt_Cargo_CheckedChanged);
            // 
            // cb_enigneType
            // 
            this.cb_enigneType.Enabled = false;
            this.cb_enigneType.FormattingEnabled = true;
            this.cb_enigneType.Items.AddRange(new object[] {
            "Gasoline",
            "Electric"});
            this.cb_enigneType.Location = new System.Drawing.Point(79, 70);
            this.cb_enigneType.Name = "cb_enigneType";
            this.cb_enigneType.Size = new System.Drawing.Size(82, 21);
            this.cb_enigneType.TabIndex = 5;
            this.cb_enigneType.SelectedIndexChanged += new System.EventHandler(this.cb_enigneType_SelectedIndexChanged);
            // 
            // lbl_engineType
            // 
            this.lbl_engineType.AutoSize = true;
            this.lbl_engineType.Location = new System.Drawing.Point(3, 73);
            this.lbl_engineType.Name = "lbl_engineType";
            this.lbl_engineType.Size = new System.Drawing.Size(70, 13);
            this.lbl_engineType.TabIndex = 6;
            this.lbl_engineType.Text = "Enigne Type:";
            // 
            // cb_Companies
            // 
            this.cb_Companies.Enabled = false;
            this.cb_Companies.FormattingEnabled = true;
            this.cb_Companies.Location = new System.Drawing.Point(248, 70);
            this.cb_Companies.Name = "cb_Companies";
            this.cb_Companies.Size = new System.Drawing.Size(104, 21);
            this.cb_Companies.TabIndex = 7;
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.Location = new System.Drawing.Point(191, 73);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(54, 13);
            this.lbl_company.TabIndex = 8;
            this.lbl_company.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lbl_model";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Model:";
            // 
            // input_Model
            // 
            this.input_Model.Location = new System.Drawing.Point(413, 70);
            this.input_Model.Name = "input_Model";
            this.input_Model.ReadOnly = true;
            this.input_Model.Size = new System.Drawing.Size(126, 20);
            this.input_Model.TabIndex = 10;
            // 
            // chkBox_Auto
            // 
            this.chkBox_Auto.AutoSize = true;
            this.chkBox_Auto.Enabled = false;
            this.chkBox_Auto.Location = new System.Drawing.Point(51, 112);
            this.chkBox_Auto.Name = "chkBox_Auto";
            this.chkBox_Auto.Size = new System.Drawing.Size(73, 17);
            this.chkBox_Auto.TabIndex = 11;
            this.chkBox_Auto.Text = "Automatic";
            this.chkBox_Auto.UseVisualStyleBackColor = true;
            this.chkBox_Auto.CheckedChanged += new System.EventHandler(this.chkBox_Auto_CheckedChanged);
            // 
            // chkBox_Manual
            // 
            this.chkBox_Manual.AutoSize = true;
            this.chkBox_Manual.Enabled = false;
            this.chkBox_Manual.Location = new System.Drawing.Point(51, 128);
            this.chkBox_Manual.Name = "chkBox_Manual";
            this.chkBox_Manual.Size = new System.Drawing.Size(61, 17);
            this.chkBox_Manual.TabIndex = 12;
            this.chkBox_Manual.Text = "Manual";
            this.chkBox_Manual.UseVisualStyleBackColor = true;
            this.chkBox_Manual.CheckedChanged += new System.EventHandler(this.chkBox_Manual_CheckedChanged);
            // 
            // lbl_gear
            // 
            this.lbl_gear.AutoSize = true;
            this.lbl_gear.Location = new System.Drawing.Point(12, 112);
            this.lbl_gear.Name = "lbl_gear";
            this.lbl_gear.Size = new System.Drawing.Size(33, 13);
            this.lbl_gear.TabIndex = 13;
            this.lbl_gear.Text = "Gear:";
            // 
            // lbl_engineCap
            // 
            this.lbl_engineCap.AutoSize = true;
            this.lbl_engineCap.Location = new System.Drawing.Point(142, 112);
            this.lbl_engineCap.Name = "lbl_engineCap";
            this.lbl_engineCap.Size = new System.Drawing.Size(87, 13);
            this.lbl_engineCap.TabIndex = 14;
            this.lbl_engineCap.Text = "Engine Capacity:";
            // 
            // input_enigneCapa
            // 
            this.input_enigneCapa.Location = new System.Drawing.Point(235, 109);
            this.input_enigneCapa.Name = "input_enigneCapa";
            this.input_enigneCapa.ReadOnly = true;
            this.input_enigneCapa.Size = new System.Drawing.Size(100, 20);
            this.input_enigneCapa.TabIndex = 15;
            // 
            // lbl_bodyType
            // 
            this.lbl_bodyType.AutoSize = true;
            this.lbl_bodyType.Location = new System.Drawing.Point(346, 112);
            this.lbl_bodyType.Name = "lbl_bodyType";
            this.lbl_bodyType.Size = new System.Drawing.Size(61, 13);
            this.lbl_bodyType.TabIndex = 16;
            this.lbl_bodyType.Text = "Body Type:";
            // 
            // cb_bodyType
            // 
            this.cb_bodyType.Enabled = false;
            this.cb_bodyType.FormattingEnabled = true;
            this.cb_bodyType.Items.AddRange(new object[] {
            "HatchBack",
            "SUV",
            "Coupe",
            "Jeep",
            "Roadster",
            "Cabariolette"});
            this.cb_bodyType.Location = new System.Drawing.Point(405, 109);
            this.cb_bodyType.Name = "cb_bodyType";
            this.cb_bodyType.Size = new System.Drawing.Size(78, 21);
            this.cb_bodyType.TabIndex = 17;
            // 
            // lbl_FuelTank
            // 
            this.lbl_FuelTank.AutoSize = true;
            this.lbl_FuelTank.Location = new System.Drawing.Point(3, 162);
            this.lbl_FuelTank.Name = "lbl_FuelTank";
            this.lbl_FuelTank.Size = new System.Drawing.Size(102, 13);
            this.lbl_FuelTank.TabIndex = 18;
            this.lbl_FuelTank.Text = "Fuel Tank Capacity:";
            // 
            // input_fuelCap
            // 
            this.input_fuelCap.Location = new System.Drawing.Point(111, 159);
            this.input_fuelCap.Name = "input_fuelCap";
            this.input_fuelCap.ReadOnly = true;
            this.input_fuelCap.Size = new System.Drawing.Size(60, 20);
            this.input_fuelCap.TabIndex = 19;
            // 
            // lbl_fuelCuns
            // 
            this.lbl_fuelCuns.AutoSize = true;
            this.lbl_fuelCuns.Location = new System.Drawing.Point(191, 162);
            this.lbl_fuelCuns.Name = "lbl_fuelCuns";
            this.lbl_fuelCuns.Size = new System.Drawing.Size(94, 13);
            this.lbl_fuelCuns.TabIndex = 20;
            this.lbl_fuelCuns.Text = "Fuel Consumption:";
            // 
            // input_fuelCons
            // 
            this.input_fuelCons.Location = new System.Drawing.Point(291, 159);
            this.input_fuelCons.Name = "input_fuelCons";
            this.input_fuelCons.ReadOnly = true;
            this.input_fuelCons.Size = new System.Drawing.Size(44, 20);
            this.input_fuelCons.TabIndex = 21;
            this.input_fuelCons.Text = "L/km";
            // 
            // lbl_manuyear
            // 
            this.lbl_manuyear.AutoSize = true;
            this.lbl_manuyear.Location = new System.Drawing.Point(357, 162);
            this.lbl_manuyear.Name = "lbl_manuyear";
            this.lbl_manuyear.Size = new System.Drawing.Size(89, 13);
            this.lbl_manuyear.TabIndex = 22;
            this.lbl_manuyear.Text = "Manufactor Year:";
            // 
            // cb_manuYear
            // 
            this.cb_manuYear.Enabled = false;
            this.cb_manuYear.FormattingEnabled = true;
            this.cb_manuYear.Location = new System.Drawing.Point(452, 159);
            this.cb_manuYear.Name = "cb_manuYear";
            this.cb_manuYear.Size = new System.Drawing.Size(74, 21);
            this.cb_manuYear.TabIndex = 23;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Location = new System.Drawing.Point(12, 196);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(44, 13);
            this.lbl_Weight.TabIndex = 24;
            this.lbl_Weight.Text = "Weight:";
            // 
            // input_weight
            // 
            this.input_weight.Location = new System.Drawing.Point(61, 193);
            this.input_weight.Name = "input_weight";
            this.input_weight.ReadOnly = true;
            this.input_weight.Size = new System.Drawing.Size(51, 20);
            this.input_weight.TabIndex = 25;
            // 
            // lbl_wheelSize
            // 
            this.lbl_wheelSize.AutoSize = true;
            this.lbl_wheelSize.Location = new System.Drawing.Point(137, 196);
            this.lbl_wheelSize.Name = "lbl_wheelSize";
            this.lbl_wheelSize.Size = new System.Drawing.Size(64, 13);
            this.lbl_wheelSize.TabIndex = 26;
            this.lbl_wheelSize.Text = "Wheel Size:";
            // 
            // input_wheelSize
            // 
            this.input_wheelSize.Location = new System.Drawing.Point(207, 193);
            this.input_wheelSize.Name = "input_wheelSize";
            this.input_wheelSize.ReadOnly = true;
            this.input_wheelSize.Size = new System.Drawing.Size(51, 20);
            this.input_wheelSize.TabIndex = 27;
            this.input_wheelSize.Text = "inch";
            // 
            // lbl_maxspeed
            // 
            this.lbl_maxspeed.AutoSize = true;
            this.lbl_maxspeed.Location = new System.Drawing.Point(273, 196);
            this.lbl_maxspeed.Name = "lbl_maxspeed";
            this.lbl_maxspeed.Size = new System.Drawing.Size(64, 13);
            this.lbl_maxspeed.TabIndex = 28;
            this.lbl_maxspeed.Text = "Max Speed:";
            // 
            // input_maxspeed
            // 
            this.input_maxspeed.Location = new System.Drawing.Point(343, 193);
            this.input_maxspeed.Name = "input_maxspeed";
            this.input_maxspeed.ReadOnly = true;
            this.input_maxspeed.Size = new System.Drawing.Size(48, 20);
            this.input_maxspeed.TabIndex = 29;
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.Location = new System.Drawing.Point(410, 196);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(69, 13);
            this.lbl_acc.TabIndex = 30;
            this.lbl_acc.Text = "Acceleration:";
            // 
            // input_Accele
            // 
            this.input_Accele.Location = new System.Drawing.Point(477, 193);
            this.input_Accele.Name = "input_Accele";
            this.input_Accele.ReadOnly = true;
            this.input_Accele.Size = new System.Drawing.Size(62, 20);
            this.input_Accele.TabIndex = 31;
            this.input_Accele.Text = "0-100 sec";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(12, 236);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(34, 13);
            this.lbl_color.TabIndex = 32;
            this.lbl_color.Text = "Color:";
            // 
            // input_color
            // 
            this.input_color.Location = new System.Drawing.Point(51, 233);
            this.input_color.Name = "input_color";
            this.input_color.ReadOnly = true;
            this.input_color.Size = new System.Drawing.Size(100, 20);
            this.input_color.TabIndex = 33;
            // 
            // lbl_liencePlate
            // 
            this.lbl_liencePlate.AutoSize = true;
            this.lbl_liencePlate.Location = new System.Drawing.Point(207, 236);
            this.lbl_liencePlate.Name = "lbl_liencePlate";
            this.lbl_liencePlate.Size = new System.Drawing.Size(75, 13);
            this.lbl_liencePlate.TabIndex = 34;
            this.lbl_liencePlate.Text = "Liecene Plate:";
            // 
            // input_liecenePl
            // 
            this.input_liecenePl.Location = new System.Drawing.Point(288, 233);
            this.input_liecenePl.Name = "input_liecenePl";
            this.input_liecenePl.ReadOnly = true;
            this.input_liecenePl.Size = new System.Drawing.Size(119, 20);
            this.input_liecenePl.TabIndex = 35;
            // 
            // butt_saveCar
            // 
            this.butt_saveCar.Location = new System.Drawing.Point(248, 322);
            this.butt_saveCar.Name = "butt_saveCar";
            this.butt_saveCar.Size = new System.Drawing.Size(104, 45);
            this.butt_saveCar.TabIndex = 36;
            this.butt_saveCar.Text = "Add Car To Stock";
            this.butt_saveCar.UseVisualStyleBackColor = true;
            this.butt_saveCar.Click += new System.EventHandler(this.butt_saveCar_Click);
            // 
            // lbl_highet
            // 
            this.lbl_highet.AutoSize = true;
            this.lbl_highet.Location = new System.Drawing.Point(160, 272);
            this.lbl_highet.Name = "lbl_highet";
            this.lbl_highet.Size = new System.Drawing.Size(41, 13);
            this.lbl_highet.TabIndex = 37;
            this.lbl_highet.Text = "Highet:";
            // 
            // input_highet
            // 
            this.input_highet.Location = new System.Drawing.Point(207, 269);
            this.input_highet.Name = "input_highet";
            this.input_highet.ReadOnly = true;
            this.input_highet.Size = new System.Drawing.Size(75, 20);
            this.input_highet.TabIndex = 38;
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(309, 272);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(43, 13);
            this.lbl_length.TabIndex = 39;
            this.lbl_length.Text = "Length:";
            // 
            // input_length
            // 
            this.input_length.Location = new System.Drawing.Point(349, 269);
            this.input_length.Name = "input_length";
            this.input_length.ReadOnly = true;
            this.input_length.Size = new System.Drawing.Size(100, 20);
            this.input_length.TabIndex = 40;
            // 
            // CatalogMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_engineCap);
            this.Controls.Add(this.butt_editstock);
            this.Controls.Add(this.butt_addnew);
            this.Controls.Add(this.butt_gotoadmn);
            this.Name = "CatalogMng";
            this.Text = "CatalogMng";
            this.input_engineCap.ResumeLayout(false);
            this.input_engineCap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_gotoadmn;
        private System.Windows.Forms.Button butt_addnew;
        private System.Windows.Forms.Button butt_editstock;
        private System.Windows.Forms.Panel input_engineCap;
        private System.Windows.Forms.Label lbl_addnew;
        private System.Windows.Forms.RadioButton rdbutt_Cargo;
        private System.Windows.Forms.RadioButton rdbutt_Motor;
        private System.Windows.Forms.RadioButton rdButt_Private;
        private System.Windows.Forms.Label lbl_vecType;
        private System.Windows.Forms.Label lbl_engineType;
        private System.Windows.Forms.ComboBox cb_enigneType;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.ComboBox cb_Companies;
        private System.Windows.Forms.Label lbl_gear;
        private System.Windows.Forms.CheckBox chkBox_Manual;
        private System.Windows.Forms.CheckBox chkBox_Auto;
        private System.Windows.Forms.TextBox input_Model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_engineCap;
        private System.Windows.Forms.TextBox input_enigneCapa;
        private System.Windows.Forms.ComboBox cb_bodyType;
        private System.Windows.Forms.Label lbl_bodyType;
        private System.Windows.Forms.TextBox input_fuelCap;
        private System.Windows.Forms.Label lbl_FuelTank;
        private System.Windows.Forms.TextBox input_fuelCons;
        private System.Windows.Forms.Label lbl_fuelCuns;
        private System.Windows.Forms.ComboBox cb_manuYear;
        private System.Windows.Forms.Label lbl_manuyear;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.TextBox input_weight;
        private System.Windows.Forms.TextBox input_wheelSize;
        private System.Windows.Forms.Label lbl_wheelSize;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.TextBox input_maxspeed;
        private System.Windows.Forms.Label lbl_maxspeed;
        private System.Windows.Forms.TextBox input_Accele;
        private System.Windows.Forms.TextBox input_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Button butt_saveCar;
        private System.Windows.Forms.TextBox input_liecenePl;
        private System.Windows.Forms.Label lbl_liencePlate;
        private System.Windows.Forms.TextBox input_highet;
        private System.Windows.Forms.Label lbl_highet;
        private System.Windows.Forms.TextBox input_length;
        private System.Windows.Forms.Label lbl_length;
    }
}
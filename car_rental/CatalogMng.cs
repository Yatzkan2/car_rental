using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace car_rental
{
    public partial class CatalogMng : Form
    {
        //Defualt lists of companys names per Vechile Type
        string[] PrivateCompanys = { "Alfa Romeo", "BMW", "Ferrari", "Lambo", "Lexus", "Bugatti" };
        string[] MotrocyleCompany = { "Yamaah", "Kawasaki" };
        string[] CargoCompanys = { "Isuzu", "Mercedes", "Chevrolette" };
        string[] ElectrisCarsCOmpany = { "Tesla", "Huyndai" };
        public static Vehicle temp; // an object to create a new object and put it into the lists
        public static int vechilePlaceinList = 0;
        public List<MotorCycle> motorlist;
        public List<GasolinePrivateCar> GasCarlist;
        public List<ElectricCar> ElectricCarlist;
        public List<Cargo> cargoList;
        public List<Vehicle> allPrivateList;

        private enum Types
        {
            MotorCycle, PrivateElectricCar, PrivateGasCar, Cargo
        };
        private int type;
        public CatalogMng()
        {
            InitializeComponent();
            for (int i = 1980; i <= 2022; i++) // Creating Years for manufactors years
                cb_manuYear.Items.Add(i);
            
            Stream stream = File.Open("MotorCycleStock.dat", FileMode.Open);
            BinaryFormatter  bf = new BinaryFormatter();
            motorlist = (List<MotorCycle>)bf.Deserialize(stream);
            stream.Close();

           
            stream = File.Open("PrivateGasStock.dat", FileMode.Open);
            bf = new BinaryFormatter();
            GasCarlist = (List<GasolinePrivateCar>)bf.Deserialize(stream);
            stream.Close();

            
            stream = File.Open("PrivateElectricStock.dat", FileMode.Open);
            bf = new BinaryFormatter();
            ElectricCarlist = (List<ElectricCar>)bf.Deserialize(stream);
            stream.Close();

            

            
            stream = File.Open("CargoStock.dat", FileMode.Open);
            bf = new BinaryFormatter();
            cargoList = (List<Cargo>)bf.Deserialize(stream);
            stream.Close();

            allPrivateList.AddRange(GasCarlist);
            allPrivateList.AddRange(ElectricCarlist);



        }

        private void butt_gotoadmn_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new adDashboard());
        }

        private void butt_addnew_Click(object sender, EventArgs e)
        {
            panel_addNew.Visible = true;
            Panel_edit.Visible = false;

        }

        private void butt_editstock_Click(object sender, EventArgs e)
        {

            panel_addNew.Visible = false;
            Panel_edit.Visible = true;
        }

        private void rdButt_Private_CheckedChanged(object sender, EventArgs e)
        {
            enablesForallPrivateCars();

        }

        private void rdbutt_Motor_CheckedChanged(object sender, EventArgs e)
        {
            enableInputs();
            enableforMotor();
            for (int i = 0; i < MotrocyleCompany.Length; i++)
            {
                cb_Companies.Items.Add(MotrocyleCompany[i].ToString());
            }
            cb_Companies.SelectedItem = cb_Companies.Items[0];

        }

        private void rdbutt_Cargo_CheckedChanged(object sender, EventArgs e)
        {
            enablesforCargo();
            enableInputs();

            for (int i = 0; i < CargoCompanys.Length; i++)
            {
                cb_Companies.Items.Add(CargoCompanys[i].ToString());
            }
            cb_Companies.SelectedItem = cb_Companies.Items[0];

        }

        private void cb_enigneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableInputs();
            cb_Companies.Enabled = true;
            if (cb_enigneType.Text == "Gasoline")
            {
                for (int i = 0; i < PrivateCompanys.Length; i++)
                    cb_Companies.Items.Add(PrivateCompanys[i].ToString());
                enablesforPrivateGas();

            }
            else
            {
                for (int i = 0; i < ElectrisCarsCOmpany.Length; i++)
                    cb_Companies.Items.Add(ElectrisCarsCOmpany[i].ToString());
                enablesforElectricCar();

            }
            cb_Companies.SelectedItem = cb_Companies.Items[0];

        }

        private void chkBox_Auto_CheckedChanged(object sender, EventArgs e)
        {
            chkBox_Manual.Checked = false;
        }

        private void enableInputs()
        {
            cb_Companies.Enabled = true;
            cb_Companies.Items.Clear();
            cb_Companies.ResetText();
            chkBox_Auto.Enabled = true;
            chkBox_Manual.Enabled = true;
            input_enigneCapa.ReadOnly = false;
            cb_bodyType.Enabled = true;
            input_fuelCap.ReadOnly = false;
            input_fuelCons.ReadOnly = false;
            cb_manuYear.Enabled = true;
            input_weight.ReadOnly = false;
            input_wheelSize.ReadOnly = false;
            input_maxspeed.ReadOnly = false;
            input_Accele.ReadOnly = false;
            input_color.ReadOnly = false;
            input_liecenePl.ReadOnly = false;
            input_Model.ReadOnly = false;



        }

        private void chkBox_Manual_CheckedChanged(object sender, EventArgs e)
        {
            chkBox_Auto.Checked = false;
        }

        private void butt_saveCar_Click(object sender, EventArgs e)
        {
            bool IsAllCorrect = CheckGlobalInputs();
            bool extraCheck = false;

            bool isGear;
            if (chkBox_Manual.Checked)
                isGear = true;
            else
                isGear = false;

            if (IsAllCorrect == true)
            {
                if (rdButt_Private.Checked)
                {

                    if (cb_enigneType.Text == "Gasoline")
                    {
                        type = 2;
                        extraCheck = true;
                        temp = new GasolinePrivateCar(cb_bodyType.Text, isGear, double.Parse(input_enigneCapa.Text), int.Parse(input_fuelCap.Text), double.Parse(input_fuelCons.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 4, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1, cb_Companies.Text + " " + input_Model.Text);
                    }
                    else // Electire private
                    {
                        type = 1;
                        extraCheck = CheckforElctric();
                        temp = new ElectricCar(double.Parse(input_Range.Text), double.Parse(input_capaa.Text), double.Parse(input_ChargeTime.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 4, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1, cb_Companies.Text + " " + input_Model.Text);
                    }
                }
                else if (rdbutt_Motor.Checked)
                {
                    type = 0;
                    extraCheck = true;
                    temp = new MotorCycle(isGear, double.Parse(input_enigneCapa.Text), int.Parse(input_fuelCap.Text), double.Parse(input_fuelCons.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 2, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1, cb_Companies.Text + " " + input_Model.Text);
                }
                else//means cargo
                {
                    type = 4;
                    extraCheck = CheckForCargo();
                    temp = new Cargo(isGear, double.Parse(input_enigneCapa.Text), int.Parse(input_fuelCap.Text), double.Parse(input_fuelCons.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 2, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1, cb_Companies.Text + " " + input_Model.Text, double.Parse(input_highet.Text), double.Parse(input_length.Text));
                }

                if (extraCheck == true)
                {
                    string message = "Are You Sure you want to add:" + cb_Companies.Text + " " + input_Model.Text + " To Stock?";
                    string caption = "Validation";
                    MessageBoxButtons button = MessageBoxButtons.OKCancel;
                    DialogResult res = MessageBox.Show(message, caption, button);
                    if (res == DialogResult.OK)
                    {
                        switch (type)
                        {
                            case 0:

                                motorlist.Add((MotorCycle)temp);
                                break;
                            case 1:
                                ElectricCarlist.Add( (ElectricCar) temp);
                                allPrivateList.Add(temp);
                                break;
                            case 2:
                               GasCarlist.Add((GasolinePrivateCar)  temp);
                                allPrivateList.Add(temp);
                                break;
                            case 3:
                                cargoList.Add((Cargo)temp);
                                break;

                        }
                        SaveAllChanges();

                        Program.OpenCenteredForm(this, new CatalogMng());
                    }
                }
                else
                    showerrormessage();

            }
            else
                showerrormessage();
        }

        private bool CheckGlobalInputs()
        {
            if (input_Model.Text.Length == 0)
                return false;
            if (chkBox_Auto.Checked == false && chkBox_Manual.Checked == false)
                return false;
            if (cb_manuYear.Text.Length == 0)
                return false;
            if (input_weight.Text.Length == 0)
                return false;
            if (input_wheelSize.Text.Length == 0)
                return false;
            if (input_maxspeed.Text.Length == 0)
                return false;
            if (input_Accele.Text.Length == 0)
                return false;
            if (input_color.Text.Length == 0)
                return false;
            if (input_liecenePl.Text.Length != 7 && input_liecenePl.Text.Length != 8)
                return false;

            return true;
        }
        private bool CheckforElctric()
        {
            if (input_Range.Text.Length == 0)
                return false;
            if (input_capaa.Text.Length == 0)
                return false;
            if (input_ChargeTime.Text.Length == 0)
                return false;
            return true;
        }
        private bool CheckForCargo()
        {
            if (input_highet.Text.Length == 0)
                return false;
            if (input_length.Text.Length == 0)
                return false;

            return true;
        }
        private void showerrormessage()
        {
            string message = "Check the input!! you have something wrong!";
            string caption = "Wrong input";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, button);
        }
        private void enablesforElectricCar()
        {
            input_capaa.ReadOnly = false;
            input_Range.ReadOnly = false;
            input_capaa.Text = null;
            input_Range.Text = null;
            input_enigneCapa.ReadOnly = true;
            chkBox_Auto.Checked = true;
            chkBox_Manual.Checked = false;
            chkBox_Auto.Enabled = false;
            chkBox_Manual.Enabled = false;
            input_fuelCons.ReadOnly = true;
            input_enigneCapa.ReadOnly = true;
        }
        private void enablesforCargo()
        {

            cb_enigneType.Enabled = false;
            cb_enigneType.SelectedItem = cb_enigneType.Items[0];
            input_highet.ReadOnly = false;
            input_length.ReadOnly = false;
            input_enigneCapa.ReadOnly = false;
            input_length.Text = null;
            input_highet.Text = null;
            input_fuelCons.ReadOnly = false;
            input_enigneCapa.ReadOnly = false;
            cb_bodyType.Enabled = false;
        }
        private void enablesforPrivateGas()
        {
            input_capaa.ReadOnly = true;
            input_Range.ReadOnly = true;
            input_enigneCapa.ReadOnly = false;

            input_fuelCons.ReadOnly = false;
            input_capaa.Text = "-";
            input_Range.Text = "-";
        }
        private void enableforMotor()
        {
            cb_enigneType.Enabled = false;
            cb_enigneType.SelectedItem = cb_enigneType.Items[0];
            input_highet.ReadOnly = true;
            input_length.ReadOnly = true;
            input_capaa.ReadOnly = true;
            input_Range.ReadOnly = true;
            input_enigneCapa.ReadOnly = false;
            input_fuelCons.ReadOnly = false;
            cb_bodyType.Enabled = false;

            input_Range.Text = "-";
            input_highet.Text = "-";
            input_length.Text = "-";
            input_capaa.Text = "-";
        }
        private void enablesForallPrivateCars()
        {
            cb_Companies.ResetText();
            cb_Companies.Enabled = false;
            cb_enigneType.Enabled = true;
            cb_enigneType.SelectedItem = cb_enigneType.Items[0];
            input_highet.ReadOnly = true;
            input_length.ReadOnly = true;
            input_capaa.ReadOnly = true;
            input_Range.ReadOnly = true;
            cb_bodyType.Enabled = true;
            input_Range.Text = "-";
            input_highet.Text = "-";
            input_length.Text = "-";
            input_capaa.Text = "-";

        }

        ///
        ///
        /// Edit Stock Panel
       

        private void cBE_vecType_SelectedIndexChanged(object sender, EventArgs e)
        {

            cBE_model.Enabled = true;
            cBE_model.Items.Clear();
            cBE_model.ResetText();
            hideWhenTypeisChanged();



            if (cBE_vecType.Text == "Private Car")
            {
                rdBE_Electric.Visible = true;
                rdBE_Gas.Visible = true;

            }
            else if (cBE_vecType.Text == "MotorCycle")
            {

                lblE_model.Visible = true;
                cBE_model.Visible = true;
                rdBE_Electric.Visible = false;
                rdBE_Gas.Visible = false;
                type = 0;
                foreach (MotorCycle motor in motorlist)
                {
                    cBE_model.Items.Add(motor.Model);

                }
            }
            else if (cBE_vecType.Text == "Cargo")
            {
                type = 3;
                lblE_model.Visible = true;
                cBE_model.Visible = true;
                rdBE_Electric.Visible = false;
                rdBE_Gas.Visible = false;
                foreach (Cargo car in cargoList)
                {
                    cBE_model.Items.Add(car.Model);
                }
            }
        }

        private void rdBE_Gas_CheckedChanged(object sender, EventArgs e)
        {
            cBE_model.Items.Clear();
            cBE_model.ResetText();
            hideWhenTypeisChanged();
            type = 2;

            foreach (GasolinePrivateCar car in GasCarlist)
            {
                lblE_model.Visible = true;
                cBE_model.Visible = true;
                cBE_model.Items.Add(car.Model);
            }
        }

        private void rdBE_Electric_CheckedChanged(object sender, EventArgs e)
        {
            cBE_model.Items.Clear();
            cBE_model.ResetText();
            hideWhenTypeisChanged();
            type = 1;
            foreach (ElectricCar car in ElectricCarlist)
            {
                lblE_model.Visible = true;
                cBE_model.Visible = true;
                cBE_model.Items.Add(car.Model);
            }
        }

        private void cBE_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            exposeWhenModelhasFound();
            vechilePlaceinList = 0;
            switch (type)
            {
                case 0: // MotorCycle
                    while (motorlist[vechilePlaceinList].Model != cBE_model.Text)
                        vechilePlaceinList++;
                    inputE_stcok.Text = motorlist[vechilePlaceinList].Amount.ToString();
                    break;

                case 1: // PrivateElectric
                    while (ElectricCarlist[vechilePlaceinList].Model != cBE_model.Text)
                        vechilePlaceinList++;
                    inputE_stcok.Text = ElectricCarlist[vechilePlaceinList].Amount.ToString();
                    break;
                case 2: // Private Gas
                    while (GasCarlist[vechilePlaceinList].Model != cBE_model.Text)
                        vechilePlaceinList++;
                    inputE_stcok.Text = GasCarlist[vechilePlaceinList].Amount.ToString();
                    break;
                case 3: // Cargo
                    while (cargoList[vechilePlaceinList].Model != cBE_model.Text)
                        vechilePlaceinList++;
                    inputE_stcok.Text = cargoList[vechilePlaceinList].Amount.ToString();
                    break;

               
            }
            
        }
        private void exposeWhenModelhasFound()
        {
            lblE_stock.Visible = true;
            inputE_stcok.Visible = true;
            buttE_edit.Visible = true;
            buttE_Save.Visible = true;
            
            buttE_delete.Visible = true;
        }
        private void hideWhenTypeisChanged()
        {
            lblE_stock.Visible = false;
            inputE_stcok.Visible = false;
            buttE_edit.Visible = false;
            buttE_Save.Visible = false;
            
            buttE_delete.Visible = false;
        }
        private void buttE_edit_Click(object sender, EventArgs e)
        {
            inputE_stcok.ReadOnly = false;
        }

        private void buttE_delete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want delete this Vechile?";
            string caption = "Validation";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, caption, button);
            if(res == DialogResult.Yes)
            {
                switch (type)
                {
                    case 0: // MotorCycle
                        motorlist.Remove(motorlist[vechilePlaceinList]);
                        break;

                    case 1: // PrivateElectric
                        ElectricCarlist.Remove(ElectricCarlist[vechilePlaceinList]);
                        break;
                    case 2: // Private Gas
                       GasCarlist.Remove(GasCarlist[vechilePlaceinList]);
                        break;
                    case 3: // Cargo
                       cargoList.Remove(cargoList[vechilePlaceinList]);
                        break;
                }
                if (type == 1 || type == 2)
                {
                    int indexinallPrivate = 0;
                    while (allPrivateList[indexinallPrivate].Model != cBE_model.Text)
                        indexinallPrivate++;
                   allPrivateList.Remove(allPrivateList[indexinallPrivate]);
                }
                SaveAllChanges();
                Program.OpenCenteredForm(this, new CatalogMng());
            }
        }

        private void buttE_Save_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to change this vechile stock";
            string caption = "Validation";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, caption, button);
            if (res == DialogResult.Yes)
            {
                switch (type)
                {
                    case 0: // MotorCycle
                        motorlist[vechilePlaceinList].Amount = int.Parse(inputE_stcok.Text);
                        break;

                    case 1: // PrivateElectric
                        ElectricCarlist[vechilePlaceinList].Amount = int.Parse(inputE_stcok.Text);
                        break;
                    case 2: // Private Gas
                        GasCarlist[vechilePlaceinList].Amount = int.Parse(inputE_stcok.Text);
                        break;
                    case 3: // Cargo
                        cargoList[vechilePlaceinList].Amount = int.Parse(inputE_stcok.Text);
                        break;
                }
                if (type == 1 || type == 2)
                {
                    int indexinallPrivate = 0;
                    while (allPrivateList[indexinallPrivate].Model != cBE_model.Text)
                        indexinallPrivate++;
                    allPrivateList[indexinallPrivate].Amount = int.Parse(inputE_stcok.Text);
                }

                SaveAllChanges();
                Program.OpenCenteredForm(this, new CatalogMng());
            }
        }

        private void butt_gotocata_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new CatalogMain());
        }

        private void SaveAllChanges()
        {
            Stream stream;
            BinaryFormatter bf;
            switch (type)
            {
                case 0:
                    stream = File.Open("MotorCycleStock.dat", FileMode.Create);
                    bf = new BinaryFormatter();
                    bf.Serialize(stream, motorlist);
                    stream.Close();
                    break;

                case 1:
                    stream = File.Open("PrivateElectricStock.dat", FileMode.Create);
                    bf = new BinaryFormatter();
                    bf.Serialize(stream, ElectricCarlist);
                    stream.Close();

                    stream = File.Open("AllPrivateStock.dat", FileMode.Create);
                    bf = new BinaryFormatter();
                    bf.Serialize(stream, allPrivateList);
                    stream.Close();
                    break;


                case 2:
                    stream = File.Open("PrivateGasStock.dat", FileMode.Create);
                    bf = new BinaryFormatter();
                    bf.Serialize(stream, GasCarlist);
                    stream.Close();
                    stream = File.Open("AllPrivateStock.dat", FileMode.Create);
                    bf = new BinaryFormatter();
                    bf.Serialize(stream, allPrivateList) ;
                    stream.Close();
                    break;

                case 3:
                    stream = File.Open("CargoStock.dat", FileMode.Create);
                    bf = new BinaryFormatter();
                    bf.Serialize(stream, cargoList);
                    stream.Close();
                    break;

            }
            //Storing the new Stock Updates
            

            

            

            

           
        }
    }
    
}
 




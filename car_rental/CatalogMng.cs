﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
        public CatalogMng()
        {
            InitializeComponent();
            for (int i = 1980; i <= 2022; i++) // Creating Years for manufactors years
                cb_manuYear.Items.Add(i);
        }

        private void butt_gotoadmn_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new adDashboard());
        }

        private void butt_addnew_Click(object sender, EventArgs e)
        {
            input_engineCap.Visible = true;

        }

        private void butt_editstock_Click(object sender, EventArgs e)
        {

            input_engineCap.Visible = false;
        }

        private void rdButt_Private_CheckedChanged(object sender, EventArgs e)
        {
            enablesForallPrivateCars();
            ///need to fix the bug that it doesnt update immedialty
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
            input_Model.ReadOnly = false;
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
                        extraCheck = true;
                        temp = new GasolinePrivateCar(cb_bodyType.Text, isGear, double.Parse(input_enigneCapa.Text), int.Parse(input_fuelCap.Text), double.Parse(input_fuelCons.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 4, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1, cb_Companies.Text + " " + input_Model.Text);
                    }
                    else // Electire private
                    {
                        extraCheck = CheckforElctric();
                        temp = new ElectricCar(double.Parse(input_Range.Text), double.Parse(input_capaa.Text), double.Parse(input_ChargeTime.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 4, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1, cb_Companies.Text + " " + input_Model.Text);
                    }
                }
                else if (rdbutt_Motor.Checked)
                {
                    extraCheck = true;
                    temp = new MotorCycle(isGear, double.Parse(input_enigneCapa.Text), int.Parse(input_fuelCap.Text), double.Parse(input_fuelCons.Text), uint.Parse(input_liecenePl.Text), double.Parse(input_weight.Text), 2, input_wheelSize.Text, double.Parse(input_Accele.Text), double.Parse(input_maxspeed.Text), uint.Parse(cb_manuYear.Text), input_color.Text, 1,cb_Companies.Text +" "+input_Model.Text);
                }
                else//means cargo
                {
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
                        Program.allPrivatelist.Add(temp);
                        Program.privateGasCarList.Add(temp);
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
            if(input_Model.Text.Length == 0)
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
            input_fuelCons.ReadOnly = false;
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
            input_Range.Text = "-";
            input_highet.Text = "-";
            input_length.Text = "-";
            input_capaa.Text = "-";
        }
        private void enablesForallPrivateCars()
        {
            cb_enigneType.Enabled = true;
            cb_enigneType.SelectedItem = cb_enigneType.Items[0];
            input_highet.ReadOnly = true;
            input_length.ReadOnly = true;
            input_capaa.ReadOnly = true;
            input_Range.ReadOnly = true;

            input_Range.Text = "-";
            input_highet.Text = "-";
            input_length.Text = "-";
            input_capaa.Text = "-";
        }
    }
}


       


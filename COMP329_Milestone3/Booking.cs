﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP329_Milestone3
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        public decimal AID { get; set; }
        public decimal RoomTypeID { get; set; }
        public string RName { get; set; }
        public float Price { get; set; }
        public string CheckInDate { get; set; }

        private void Booking_Load(object sender, EventArgs e)
        {
            lb_RName.Text = RName;
            lb_Price.Text = "NZ $" + Price;
            lb_CheckInDate.Text = CheckInDate;

            //??????????????????????
            //GET ACCOMMODATION NAME
            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "SELECT AName FROM Accommodation WHERE AID =" + AID;
            OracleDataReader reader = myCommand.ExecuteReader();
            reader.Read();
            lb_AName.Text = (string)reader["ANAME"];
            reader.Close();
            myConnection.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            string fname = tb_FirstName.Text.Trim();
            string lname = tb_LastName.Text.Trim();
            string dob = dtp_DoB.Value.ToString("dd/MM/yyyy");
            string phone = tb_PhoneNo.Text.Trim();
            string email = tb_Email.Text.Trim();

            int rowUpdated = -1;
            decimal CID = -1;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            //check if has customer
            myCommand.CommandText = "SELECT CUSTOMERID FROM CUSTOMER WHERE EMAIL = '" + email + "'";
            OracleDataReader reader = myCommand.ExecuteReader();
            //reader.Read();
            if(reader.HasRows)
            {
                //has user
                reader.Read();
                CID = (decimal)reader["CUSTOMERID"];
                reader.Close();
            }
            else
            {
                //new user, insert customer
                myCommand.CommandText = "INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (11,'"+fname+"','"+lname+"','"+dob+"','"+phone+"','"+email+"')";
                rowUpdated = myCommand.ExecuteNonQuery();
                if(rowUpdated == 0)
                    MessageBox.Show("Customer not inserted","Failed",MessageBoxButtons.OK);
                else
                    CID = 11;
            }
            //insert booking
            myCommand.CommandText = "INSERT INTO BOOKING (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (13,"+ Price + ",'" +dob + "'," + RoomTypeID + "," + CID + ")";
            rowUpdated = myCommand.ExecuteNonQuery();
            if (rowUpdated == 0)
                MessageBox.Show("Booking Failed", "Failed", MessageBoxButtons.OK);
            else
                MessageBox.Show("Thank you for booking with us!", "Successed", MessageBoxButtons.OK);

            this.Close();
        }
    }
}

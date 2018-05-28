using System.Data.OracleClient;
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
        public string AName { get; set; }
        public decimal RoomTypeID { get; set; }
        public string RName { get; set; }
        public decimal Price { get; set; }
        public string CheckInDate { get; set; }

        private void Booking_Load(object sender, EventArgs e)
        {
            lb_RName.Text = RName;
            lb_Price.Text = "NZ $" + Price;
            lb_CheckInDate.Text = CheckInDate;
            
            lb_AName.Text = AName;
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            string fname = tb_FirstName.Text.Trim();
            string lname = tb_LastName.Text.Trim();
            string dob = string.Format("{0:dd-MMM-yyyy}", dtp_DoB.Value);
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

            if (reader.HasRows)
            {
                //has user
                reader.Read();
                CID = (decimal)reader["CUSTOMERID"];
                reader.Close();
            }
            else
            {
                //new user, insert customer
                myCommand.CommandText = "INSERT INTO Customer (CustomerID,CFName,CLName,DoB,phone,email) VALUES (customerID.nextval,'" + fname + "','" + lname + "','" + dob + "','" + phone + "','" + email + "')";
                rowUpdated = myCommand.ExecuteNonQuery();
                if (rowUpdated == 0)
                    MessageBox.Show("Customer not inserted", "Failed", MessageBoxButtons.OK);
                else
                {
                    //get inserted id
                    myCommand.CommandText = "SELECT CUSTOMERID.currval FROM DUAL";
                    reader = myCommand.ExecuteReader();
                    reader.Read();
                    CID = (decimal)reader["currval"];
                    reader.Close();
                }
            }
            //insert booking
            myCommand.CommandText = "INSERT INTO BOOKING (BookingID,price,CheckInDate,RoomTypeID,CustomerID) VALUES (BookingID.nextval," + Price + ",'" + CheckInDate + "'," + RoomTypeID + "," + CID + ")";
            rowUpdated = myCommand.ExecuteNonQuery();
            if (rowUpdated == 0)
                MessageBox.Show("Booking Failed", "Failed", MessageBoxButtons.OK);
            else
                MessageBox.Show("Thank you for booking with us!", "Successed", MessageBoxButtons.OK);

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

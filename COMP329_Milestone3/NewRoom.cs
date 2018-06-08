using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP329_Milestone3
{
    public partial class NewRoom : Form
    {
        public NewRoom()
        {
            InitializeComponent();
        }

        public decimal AID { get; set;}

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string RName = tb_RName.Text.Trim();
            string quantity = tb_Quantity.Text.Trim();
            bool isValid = decimal.TryParse(tb_Price.Text.Trim(), out decimal price);
            string desc = tb_Description.Text.Trim();
            if (!isValid)
            {
                MessageBox.Show("Invalid Price Entered", "Error", MessageBoxButtons.OK);
                return;
            }
            

            price = Decimal.Round(price,2); 
            int rowUpdated = -1;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;

            myCommand.CommandText = "INSERT INTO ROOM (RoomTypeID,price,description,quantity,RName,AccommodationID) VALUES (roomID.nextval,'" + price + "','" + desc + "'," + quantity + ",'" + RName + "'," + AID + ")";
            rowUpdated = myCommand.ExecuteNonQuery();

            if (rowUpdated == 0)
                MessageBox.Show("Adding a new Room failed", "Failed", MessageBoxButtons.OK);
            else
                MessageBox.Show("New Room added!", "Success", MessageBoxButtons.OK);

            myConnection.Close();

            Hide();
            ViewRooms form = new ViewRooms();
            form.AID = AID;
            form.ShowDialog();
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            ViewRooms form = new ViewRooms();
            form.AID = AID;
            form.ShowDialog();
            Close();
        }
    }
}

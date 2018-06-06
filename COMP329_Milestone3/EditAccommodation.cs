using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace COMP329_Milestone3
{
    public partial class EditAccommodation : Form
    {
        public EditAccommodation()
        {
            InitializeComponent();
        }

        public decimal AID { get; set; }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string newName = tb_AName.Text.Trim();
            string street = tb_Street.Text.Trim();
            string city = tb_City.Text.Trim();
            string region = tb_Region.Text.Trim();
            string desc = tb_Description.Text.Trim();

            int rowUpdated = -1;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            
            myCommand.CommandText = "UPDATE ACCOMMODATION SET ANAME ='" + newName + "', STREET ='" + street + "', CITY ='" + city + "', REGION ='" + region + "', DESCRIPTION ='" + desc + "' WHERE AID =" + AID;
            rowUpdated = myCommand.ExecuteNonQuery();

            if (rowUpdated == 0)
                MessageBox.Show("Updating your accommodation failed", "Failed", MessageBoxButtons.OK);
            else
                MessageBox.Show("Your accommodation details have now been updated!", "Success", MessageBoxButtons.OK);
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

        private void EditAccommodation_Load(object sender, EventArgs e)
        {
            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = "SELECT ANAME, STREET, CITY, REGION, DESCRIPTION FROM ACCOMMODATION WHERE AID = " + AID;
            OracleDataReader reader = myCommand.ExecuteReader();
            reader.Read();

            string AName = (string)reader["ANAME"];
            string street = (string)reader["STREET"];
            string city = (string)reader["city"];
            string region = (string)reader["region"];
            string description = (string)reader["description"];

            lb_AName.Text = AName;
            tb_AName.Text = AName;
            tb_Street.Text = street;
            tb_City.Text = city;
            tb_Region.Text = region;
            tb_Description.Text = description;
            
            reader.Close();
            myConnection.Close();
        }
    }
}

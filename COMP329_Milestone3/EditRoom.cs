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
    public partial class EditRoom : Form
    {
        public EditRoom()
        {
            InitializeComponent();
        }

        public Room room { get; set; }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            lb_RName.Text = room.RName;
            tb_RName.Text = room.RName;
            tb_Quantity.Text = room.Quantity.ToString();
            tb_Description.Text = room.Description;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = tb_RName.Text.Trim();
            bool isvalid = decimal.TryParse(tb_Quantity.Text.Trim(), out decimal quantity);
            if (!isvalid)
            {
                MessageBox.Show("Invalid Quantity Value, Please Try Again!", "Error", MessageBoxButtons.OK);
                return;
            }
            isvalid = decimal.TryParse(tb_Price.Text.Trim(), out decimal price);
            if (!isvalid)
            {
                MessageBox.Show("Invalid Price Value, Please Try Again!", "Error", MessageBoxButtons.OK);
                return;
            }
            price = Math.Round(price, 2);
            string des = tb_Description.Text.Trim();

            OracleConnection myConnection = new OracleConnection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = "UPDATE ROOM SET PRICE = " + price + ", DESCRIPTION = '" + des + "', QUANTITY = " + quantity + ", RNAME = '" + name + "' WHERE ROOMTYPEID = " + room.RoomTypeID;
            int rowUpdated = -1;
            rowUpdated = myCommand.ExecuteNonQuery();
            if(rowUpdated == 0)
                MessageBox.Show("Room not updated", "Failed", MessageBoxButtons.OK);
            else
                MessageBox.Show("Room updated successfully!", "Successed", MessageBoxButtons.OK);

            myConnection.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

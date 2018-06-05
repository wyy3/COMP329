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
    public partial class ViewRooms : Form
    {
        public ViewRooms()
        {
            InitializeComponent();
        }

        public decimal AID { get; set; }
        public string AName { get; set; }

        private void btn_EditAccom_Click(object sender, EventArgs e)
        {
            EditAccommodation editAccommodation = new EditAccommodation();
            editAccommodation.AID = AID;
            editAccommodation.ShowDialog();
        }

        private void ViewRooms_Load(object sender, EventArgs e)
        {
            lb_AName.Text = AName;
            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "SELECT ROOMTYPEID, PRICE, DESCRIPTION, QUANTITY, RNAME FROM ROOM WHERE ACCOMMODATIONID = " + AID;
            OracleDataReader reader = myCommand.ExecuteReader();

            int top = 10;

            while (reader.Read())
            {
                Room data = new Room
                {
                    RoomTypeID = (decimal)reader["RoomTypeID"],
                    Price = (decimal)reader["Price"],
                    Description = (string)reader["Description"],
                    Quantity = (decimal)reader["Quantity"],
                    RName = (string)reader["RName"]
                };

                var myUserControl = new Uc_ViewRooms
                {
                    Top = top,
                    Left = 50,
                    data = data
                };

                myUserControl.DataBind();

                top = top + myUserControl.Height + 30;
                pn_Container.Controls.Add(myUserControl);
            }
            reader.Close();
            myConnection.Close();
        }
    }
}

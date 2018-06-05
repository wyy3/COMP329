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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        public decimal AID { get; set; }
        public string AName { get; set; }

        private void Rooms_Load(object sender, EventArgs e)
        {
            lb_AName.Text = AName;
            LoadRooms();
        }

        private void LoadRooms()
        {
            pn_Container.Controls.Clear();
            
            string date = string.Format("{0:dd-MMM-yyyy}", dtp_CheckInDate.Value);

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            
            myCommand.CommandText = "SELECT ROOMTYPEID, PRICE, DESCRIPTION, QUANTITY, RNAME, ACCOMMODATIONID FROM ROOM r WHERE r.ACCOMMODATIONID = " + AID +
                " AND r.QUANTITY > coalesce ((SELECT COUNT(bc.ROOMTYPEID) FROM Booking bc WHERE bc.CHECKINDATE = '" + date + "' AND r.ROOMTYPEID = bc.ROOMTYPEID GROUP BY bc.ROOMTYPEID),0)";
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
                    RName = (string)reader["RName"],
                    AID = (decimal)reader["AccommodationID"],
                    CheckInDate = date,
                    AName = AName
                };

                var myUserControl = new Uc_Rooms
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

        private void dtp_CheckInDate_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}

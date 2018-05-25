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

            string date = dtp_CheckInDate.Value.ToString("dd/MM/yyyy");

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();

            //NEED TO TEST THIS QUERY!!!
            myCommand.CommandText = "SELECT ROOMTYPEID, PRICE, DESCRIPTION, QUANTITY, RNAME, ACCOMMODATIONID FROM ROOM r WHERE r.ACCOMMODATIONID = " + AID +
                " AND r.QUANTITY > coalesce ((SELECT COUNT(bc.ROOMTYPEID) FROM Booking bc WHERE bc.CHECKINDATE = '" + date + "' AND r.ROOMTYPEID = bc.ROOMTYPEID GROUP BY bc.ROOMTYPEID),0)";
            OracleDataReader reader = myCommand.ExecuteReader();

            int top = 10;

            while (reader.Read())
            {
                Room data = new Room();
                data.RoomTypeID = (decimal)reader["RoomTypeID"];
                data.Price = (decimal)reader["Price"];
                data.Description = (string)reader["Description"];
                data.Quantity = (decimal)reader["Quantity"];    //maybe dont need this?
                data.RName = (string)reader["RName"];
                data.AID = (decimal)reader["AccommodationID"];
                data.CheckInDate = date;
                data.AName = AName;

                var myUserControl = new Uc_Rooms();
                myUserControl.Top = top;
                myUserControl.Left = 50;
                myUserControl.data = data;

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

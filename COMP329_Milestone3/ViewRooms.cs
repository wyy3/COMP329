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

        private void btn_EditAccom_Click(object sender, EventArgs e)
        {
            Hide();
            EditAccommodation editAccommodation = new EditAccommodation();
            editAccommodation.AID = AID;
            editAccommodation.ShowDialog();
            Close();
        }

        private void ViewRooms_Load(object sender, EventArgs e)
        {
            bool Loaded = false;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "SELECT a.ANAME, ROOMTYPEID, PRICE, r.DESCRIPTION, QUANTITY, RNAME FROM ROOM r INNER JOIN ACCOMMODATION a ON r.ACCOMMODATIONID = a.AID AND r.ACCOMMODATIONID =" + AID;
            OracleDataReader reader = myCommand.ExecuteReader();

            int top = 10;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(!Loaded)
                    {
                        string AName = (string)reader["AName"];
                        lb_AName.Text = AName;
                        Loaded = true;
                    }
                    
                    Room data = new Room
                    {
                        RoomTypeID = (decimal)reader["RoomTypeID"],
                        Price = (decimal)reader["Price"],
                        Description = (string)reader["Description"],
                        Quantity = (decimal)reader["Quantity"],
                        RName = (string)reader["RName"],
                        AID = AID
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
            }
            else
                lb_NoRoom.Visible = true;

            reader.Close();
            myConnection.Close();
        }

        private void llb_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Company company = new Company();
            company.ShowDialog();
            Close();
        }

        private void btn_NewAccommodation_Click(object sender, EventArgs e)
        {
            Hide();
            NewRoom form = new NewRoom();
            form.ShowDialog();
            Close();
        }
    }
}

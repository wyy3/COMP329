using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace COMP329_Milestone3
{
    public partial class Uc_ViewAccommodations : UserControl
    {
        public Uc_ViewAccommodations()
        {
            InitializeComponent();
        }

        public Accommodation data
        {
            get; set;
        }

        public void DataBind()
        {
            lb_AName.Text = data.AName;
            lb_Description.Text = data.Description;
            lb_Address.Text = data.Address;
            lb_PhoneNO.Text = data.PhoneNo;
            lb_Email.Text = data.Email;
        }

        private void btn_ViewRoom_Click(object sender, EventArgs e)
        {
            ViewRooms rooms = new ViewRooms();
            rooms.AID = data.AID;
            rooms.AName = data.AName;
            rooms.ShowDialog();
        }
    }
}

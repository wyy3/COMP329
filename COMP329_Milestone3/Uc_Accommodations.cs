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
    public partial class Uc_Accommodations : UserControl
    {
        public Uc_Accommodations()
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

        private void btn_ViewDeal_Click(object sender, EventArgs e)
        {
            var room = new Rooms();
            room.AID = data.AID;
            room.AName = data.AName;
            room.ShowDialog();            
        }
    }
}

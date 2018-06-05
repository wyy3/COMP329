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
        }
    }
}

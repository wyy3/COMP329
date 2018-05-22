using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP329_Milestone3
{
    public partial class Uc_Rooms : UserControl
    {
        public Uc_Rooms()
        {
            InitializeComponent();
        }

        public Room data { get; set; }

        public void DataBind()
        {
            lb_RName.Text = data.RName;
            lb_Description.Text = data.Description;
            lb_Price.Text = "NZ $" + data.Price;
        }
    }
}

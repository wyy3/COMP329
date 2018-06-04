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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            Singleton company = Singleton.Instance;
            lb_CName.Text = company.GetCompanyName();
        }

        private void btn_NewAccommodation_Click(object sender, EventArgs e)
        {
            NewAccommodation form = new NewAccommodation();
            form.ShowDialog();
     
        }
    }
}

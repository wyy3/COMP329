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
    public partial class fm_Booking : Form
    {
        public fm_Booking()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            var myConnection = Db.Connection();
            myConnection.Open();
            var myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM Company";
            var reader = myCommand.ExecuteReader();
            reader.Read();
            Console.WriteLine(reader["CompanyID"]);
        }
    }
}

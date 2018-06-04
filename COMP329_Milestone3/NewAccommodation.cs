using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace COMP329_Milestone3
{
    public partial class NewAccommodation : Form
    {
        public NewAccommodation()
        {
            InitializeComponent();
        }

        private void NewAccommodation_Load(object sender, EventArgs e)
        {
            Singleton company = Singleton.Instance;
            decimal companyID = company.GetCompanyID();
            
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Singleton company = Singleton.Instance;
            decimal companyID = company.GetCompanyID();

            string AName = tb_AName.Text.Trim();
            string street = tb_Street.Text.Trim();
            string city = tb_City.Text.Trim();
            string region = tb_Region.Text.Trim();
            string desc = tb_Description.Text.Trim();

            int rowUpdated = -1;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;

            myCommand.CommandText = "INSERT INTO ACCOMMODATION (AID,ANAME,STREET,CITY,REGION,DESCRIPTION,COMPANYID) VALUES (accommodationID.nextval,'" + AName + "','" + street + "','" + city + "','" + region + "','" + desc + "','" + companyID + "')";
            rowUpdated = myCommand.ExecuteNonQuery();

            if (rowUpdated == 0)
                MessageBox.Show("Adding a new Accommodation failed", "Failed", MessageBoxButtons.OK);
            else
                MessageBox.Show("Thank you for adding a new accommodation with us!", "Success", MessageBoxButtons.OK);

            myConnection.Close();
            Close();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

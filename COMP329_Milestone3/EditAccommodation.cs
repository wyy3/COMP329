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
    public partial class EditAccommodation : Form
    {
        public EditAccommodation()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Singleton company = Singleton.Instance;
            decimal companyID = company.GetCompanyID();

            string AID = tb_AID.Text.Trim();
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


            //check if a Accommodation already exists
            myCommand.CommandText = "SELECT AID FROM ACCOMMODATION WHERE AID ='" + AID + "' AND COMPANYID = '" + companyID + "'";
            OracleDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                myCommand.CommandText = "UPDATE ACCOMMODATION SET ANAME ='" + AName + "', STREET ='" + street + "', CITY ='" + city + "', REGION ='" + region + "', DESCRIPTION ='" + desc + "' WHERE AID ='" + AID + "' AND COMPANYID ='" + companyID +  "'";
                rowUpdated = myCommand.ExecuteNonQuery();

                if (rowUpdated == 0)
                    MessageBox.Show("Updating your accommodation failed", "Failed", MessageBoxButtons.OK);
                else
                {
                    MessageBox.Show("Your accommodation details have now been updated!", "Success", MessageBoxButtons.OK);
                }

            }
            else
            {
                reader.Close();
                MessageBox.Show("Accommodation does not exist", "Failed", MessageBoxButtons.OK);
            }

            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

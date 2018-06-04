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
    public partial class CompanyRegister : Form
    {
        public CompanyRegister()
        {
            InitializeComponent();
        }

        private void llb_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            Close();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            Hide();
            CompanySignIn form = new CompanySignIn();
            form.ShowDialog();
            Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string CName = tb_CName.Text.Trim();
            string password = tb_Password.Text.Trim();
            string email = tb_Email.Text.Trim();
            string phone = tb_PhoneNO.Text.Trim();

            int rowUpdated = -1;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            //check if a company already exists
            myCommand.CommandText = "SELECT COMPANYID FROM COMPANY WHERE CNAME = '" + CName + "'";
            OracleDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                MessageBox.Show("Company already exists", "Failed", MessageBoxButtons.OK);
            }
            else
            {
                myCommand.CommandText = "INSERT INTO Company (CompanyID,CName,password,phone,email) VALUES (companyID.nextval,'" + CName + "','" + password + "','" + phone + "','" + email + "')";
                rowUpdated = myCommand.ExecuteNonQuery();

                if (rowUpdated == 0)
                    MessageBox.Show("Registering new company failed", "Failed", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Thank you for registering your company with us!", "Success", MessageBoxButtons.OK);

                Hide();
                MainForm form = new MainForm();
                form.ShowDialog();
                Close();
            }
            
        }
    }
}

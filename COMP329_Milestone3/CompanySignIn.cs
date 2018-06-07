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
    public partial class CompanySignIn : Form
    {
        public CompanySignIn()
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
            string email = tb_Email.Text.Trim();
            string password = tb_Password.Text;

            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "SELECT CompanyID, CName FROM Company WHERE Email ='" + email + "' AND Password ='" + password + "'";
            OracleDataReader reader = myCommand.ExecuteReader();
            if(reader.HasRows)
            {
                //has user
                reader.Read();
                decimal CID = (decimal)reader["CompanyID"];
                string CName = (string)reader["CName"];
                
                //stores company info
                Singleton user = Singleton.Instance;
                user.CompanyInfo(CID,CName);
                
                Company form = new Company();
                Hide();
                form.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password, please try again.", "Login Failed", MessageBoxButtons.OK);
                tb_Email.Clear();
                tb_Password.Clear();
            }
            reader.Close();
            myConnection.Close();
        }        
    }
}

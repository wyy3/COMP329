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
            decimal companyID = company.GetCompanyID();

            string cmd = "SELECT AID,AName,street,city,region,description,phone,email FROM ACCOMMODATION a INNER JOIN Company c on a.COMPANYID = c.COMPANYID WHERE a.COMPANYID ='" + companyID + "'";
            LoadUserControls(cmd);
        }


        private void LoadUserControls(string cmd)
        {
            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = cmd;
            OracleDataReader reader = myCommand.ExecuteReader();

            int top = 10;

            while (reader.Read())
            {
                Accommodation data = new Accommodation();

                data.AID = (decimal)reader["AID"];
                data.AName = reader["AName"].ToString();
                data.Address = reader["STREET"].ToString() + ", " + reader["CITY"].ToString() + ", " + reader["REGION"].ToString();
                data.Description = reader["DESCRIPTION"].ToString();
                data.PhoneNo = reader["PHONE"].ToString();
                data.Email = reader["EMAIL"].ToString();

                var myUserControl = new Uc_Accommodations();
                myUserControl.Top = top;
                myUserControl.Left = 35;
                myUserControl.data = data;

                myUserControl.DataBind();

                top = top + myUserControl.Height + 10;
                pn_Container.Controls.Add(myUserControl);
            }
            reader.Close();
            myConnection.Close();
        }



        private void btn_NewAccommodation_Click(object sender, EventArgs e)
        {
            NewAccommodation form = new NewAccommodation();
            form.ShowDialog();
     
        }

        private void btn_EditAccommodation_Click(object sender, EventArgs e)
        {
            EditAccommodation form = new EditAccommodation();
            form.ShowDialog();
        }

    }
}

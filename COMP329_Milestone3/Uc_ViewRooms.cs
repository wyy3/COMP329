﻿using System;
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
    public partial class Uc_ViewRooms : UserControl
    {
        public Uc_ViewRooms()
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

        private void btn_EditRoom_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            EditRoom editRoom = new EditRoom();
            editRoom.room = data;
            editRoom.ShowDialog();
            ((Form)TopLevelControl).Close();
        }
    }
}

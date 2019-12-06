﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN
{
    public partial class frm_cauhinh : Form
    {
        public frm_cauhinh()
        {
            InitializeComponent();
        }
        cauhinh kt = new cauhinh();
        private void frm_cauhinh_Load(object sender, EventArgs e)
        {
            DataTable dataTable = kt.GetServerName();
            cbb_server.Items.Clear();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                foreach (System.Data.DataColumn col in dataTable.Columns)
                {
                    cbb_database.Items.Add(row[col] + "\\SQLEXPRESS");
                }
            }
        }

        private void btn_ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                kt.SaveConfig(cbb_server.Text.ToString(), txt_username.Text.ToString().Trim(), txt_password.Text.ToString().Trim(), cbb_database.Text.ToString().Trim());
                MessageBox.Show("thiết lập thành công");
            }
            catch
            {
                MessageBox.Show("thiết lập thất bại");
            }
        }
        private void cbb_server_DropDown(object sender, EventArgs e)
        {
            cbb_server.DataSource = kt.GetServerName();
            cbb_server.DisplayMember = "ServerName";
        }

        private void cbb_database_DropDown(object sender, EventArgs e)
        {
            DataTable dt = kt.GetDBName(cbb_server.Text.ToString());
            cbb_database.DataSource = dt;
            cbb_database.DisplayMember = "name";
        }

        private void cbb_database_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool CheckedBeforSearchNameDB()
        {
            if (cbb_server.Text.Length > 0 && txt_username.Text.Length > 0 && txt_password.Text.Length > 0)
                return true;
            return false;
        }

        private void cbb_server_TextChanged(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cbb_database.Items.Clear();

                List<string> _list = kt.GetDatabaseName(cbb_server.Text.ToString(), txt_username.Text.ToString(), txt_password.Text.ToString());
                if (_list == null)
                {
                    return;
                }
                foreach (string item in _list)
                {
                    cbb_database.Items.Add(item);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
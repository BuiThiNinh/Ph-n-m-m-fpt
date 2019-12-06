using System;
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
    public partial class frm_xemTTNCC : Form
    {
        public frm_xemTTNCC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_NCC ncc = new frm_NCC();
            ncc.Show();
        }

        private void frm_xemTTNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPT_SHOPDataSet.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.fPT_SHOPDataSet.NCC);

        }
    }
}

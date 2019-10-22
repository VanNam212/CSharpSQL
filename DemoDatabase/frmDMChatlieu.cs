using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDatabase
{
    public partial class frmDMChatlieu : Form
    {
        ConnectAndQuery query;
        public frmDMChatlieu()
        {
            InitializeComponent();
            query = new Form1().Query;
            fill();
        }

        private void fill()
        {
            DataTable data = query.LoadData("select * from tblChatlieu");
            dataGridView1.DataSource = data;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblChatlieu values(N'" + txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
            query.Run(sql);
            fill();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
            fill();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtMachatlieu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenchatlieu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblChatlieu where MaChatlieu=N'" + txtMachatlieu.Text + "'";
            query.Run(sql);
            //sql = "delete from tblHang where ";
            BtnBoqua_Click(null, null);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            string sql = "update tblChatlieu set Tenchatlieu=N'" + txtTenchatlieu.Text + "' where MaChatlieu=N'"+txtMachatlieu.Text+"'";
            query.Run(sql);
            BtnBoqua_Click(null, null);
        }
    }
}

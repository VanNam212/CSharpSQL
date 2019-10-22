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
    public partial class frmDMHang : Form
    {
        ConnectAndQuery query;
        public frmDMHang()
        {
            InitializeComponent();
            query = new Form1().Query;
            //fill();
        }

        private void fill()
        {
            DataTable data = query.LoadData("select * from tblHang");
            dataGridView1.DataSource = data;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            //string sql = "insert into tblChatlieu values(N'" + txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
            //query.Run(sql);
            //fill();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblHang where Mahang=N'" + txtMahang.Text + "'";
            query.Run(sql);
            BtnBoqua_Click(null, null);
            sql = "delete from tblChatlieu where MaChatlieu=N'" + cboMachatlieu.Text + "'";
            query.Run(sql);
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txtMahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cboMachatlieu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

        }

        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            txtAnh.Text = "";
            txtDongiaban.Text = "";
            txtDongianhap.Text = "";
            txtGhichu.Text = "";
            txtMahang.Text = "";
            txtSoluong.Text = "";
            txtTenhang.Text = "";
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void BtnHienthi_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void addMaChatlieu()
        {

        }
    }
}

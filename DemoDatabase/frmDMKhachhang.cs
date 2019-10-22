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
    public partial class frmDMKhachhang : Form
    {
        ConnectAndQuery query;
        public frmDMKhachhang()
        {
            InitializeComponent();
            query = new Form1().Query;
            fill();
        }

        private void fill()
        {
            DataTable data = query.LoadData("select * from tblKhach");
            dataGridView1.DataSource = data;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            fill();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblKhach values(N'" + txtMakhach.Text + "',N'" + txtTenkhach.Text + "',N'" + txtDiachi.Text + "',N'" + mskDienthoai.Text + "')";
            query.Run(sql);
            fill();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblKhach where Makhach=N'" + txtMakhach.Text + "'";
            query.Run(sql);
            fill();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblKhach set Tenkhach=N'" + txtTenkhach.Text + "', Diachi=N'" + txtDiachi.Text + "', Dienthoai=N'" + mskDienthoai.Text + "' where Makhach=N'"+txtMakhach.Text+"'";
            query.Run(sql);
            fill();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txtMakhach.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenkhach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mskDienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

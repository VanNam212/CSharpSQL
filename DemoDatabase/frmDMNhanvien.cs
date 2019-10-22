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
    public partial class frmDMNhanvien : Form
    {
        ConnectAndQuery query;
        public frmDMNhanvien()
        {
            InitializeComponent();
            query = new Form1().Query;
            fill();
        }

        private void fill()
        {
            DataTable data = query.LoadData("select * from tblNhanvien");
            dataGridView1.DataSource = data;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblNhanvien values(N'" + txtManhanvien.Text + "',N'" + txtTennhanvien.Text + "',";
            if (chkGioitinh.Checked)
            {
                sql += "'nam',";
            }
            else
            {
                sql += "'nu',";
            }
            sql += "N'" + txtDiachi.Text + "',N'" + mskDienthoai.Text + "','" + mskNgaysinh.Text + "'";
            query.Run(sql);
            fill();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            chkGioitinh.Checked = false;
            mskDienthoai.Text = "";
            mskNgaysinh.Text = "";
            fill();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblNhanvien set Tennhanvien=N'" + txtTennhanvien.Text + "' where Manhanvien=N'" + txtManhanvien.Text + "'";
            query.Run(sql);
            fill();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblNhanvien where Manhanvien=N'" + txtManhanvien.Text + "'";
            query.Run(sql);
            fill();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txtManhanvien.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTennhanvien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "nam")
            {
                chkGioitinh.Checked = true;
            }
            else
            {
                chkGioitinh.Checked = false;
            }
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mskDienthoai.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mskNgaysinh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

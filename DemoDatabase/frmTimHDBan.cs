using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDatabase
{
    public partial class frmTimHDBan : Form
    {
        ConnectAndQuery query;
        public frmTimHDBan()
        {
            InitializeComponent();
            query = new Form1().Query;
            fill("select * from tblHDBan");
        }

        private void fill(string sql)
        {
            DataTable data = query.LoadData(sql);
            dataGridView.DataSource = data;
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from tblHDBan where MaHDBan is not null ";
            if (txtMaHDBan.Text.Trim() != "")
            {
                sql += " and MaHDBan like N'%" + txtMaHDBan.Text + "%'";
            }
            if (txtMakhach.Text.Trim() != "")
            {
                sql += " and Makhach like N'%" + txtMakhach.Text + "%'";
            }
            if (txtManhanvien.Text.Trim() != "")
            {
                sql += " and Manhanvien like N'%" + txtManhanvien.Text + "%'";
            }
            if (txtTongtien.Text.Trim() != "")
            {
                sql += " and Tongtien = " + txtTongtien.Text;
            }
            if (txtThang.Text.Trim() != "")
            {
                sql += " and month(Ngayban) = " + txtThang.Text;
            }
            if (txtNam.Text.Trim() != "")
            {
                sql += " and year(Ngayban) = " + txtNam.Text;
            }
            fill(sql);
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTimlai_Click(object sender, EventArgs e)
        {
            txtMaHDBan.Text = "";
            txtMakhach.Text = "";
            txtManhanvien.Text = "";
            txtNam.Text = "";
            txtThang.Text = "";
            txtTongtien.Text = "";
            fill("select * from tblHDBan");
        }

    }
}

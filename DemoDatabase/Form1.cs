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
    public partial class Form1 : Form
    {
        ConnectAndQuery query;

        internal ConnectAndQuery Query { get => query; set => query = value; }

        public Form1()
        {
            InitializeComponent();
            Query = new ConnectAndQuery();
            Query.Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
            label1.ForeColor = Color.Blue;
            label2.ForeColor = Color.Brown;
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query.DisConnect();
            this.Close();
        }

        private void ChấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDMChatlieu().ShowDialog();
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDMNhanvien().ShowDialog();
        }

        private void KháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDMKhachhang().ShowDialog();
        }

        private void HàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDMHang().ShowDialog();
        }

        private void HóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmHoadonBan().ShowDialog();
        }

        private void HóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmTimHDBan().ShowDialog();
        }
    }
}

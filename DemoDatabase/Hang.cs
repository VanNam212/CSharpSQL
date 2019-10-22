using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabase
{
    class Hang
    {
        string MaHang;
        string TenHang;
        string MaChatLieu;
        float SoLuong;
        float DonGiaNhap;
        float DonGiaBan;
        string Anh;
        string GhiChu;

        public Hang(string maHang, string tenHang, string maChatLieu, float soLuong, float donGiaNhap, float donGiaBan, string anh, string ghiChu)
        {
            MaHang1 = maHang;
            TenHang1 = tenHang;
            MaChatLieu1 = maChatLieu;
            SoLuong1 = soLuong;
            DonGiaNhap1 = donGiaNhap;
            DonGiaBan1 = donGiaBan;
            Anh1 = anh;
            GhiChu1 = ghiChu;
        }

        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public string TenHang1 { get => TenHang; set => TenHang = value; }
        public string MaChatLieu1 { get => MaChatLieu; set => MaChatLieu = value; }
        public float SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
        public float DonGiaBan1 { get => DonGiaBan; set => DonGiaBan = value; }
        public string Anh1 { get => Anh; set => Anh = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    }
}

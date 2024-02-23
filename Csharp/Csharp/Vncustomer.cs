using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Csharp
{
    internal class Vncustomer:Customer
    {
        public string LoaiKhachHang {  get; set; }
        public int SoLuong { get; set; }
        public string dongia {  get; set; }
        public Vncustomer(string id, string name, DateTime day, string loaiKhachHang, int soLuong, string donGia)
        {
            ID = id;
            Name = name;
            Day = day;
            LoaiKhachHang = loaiKhachHang;
            SoLuong = soLuong;
            dongia = donGia;
        }
        private int Soluongtieuchuan()
        {
            if (SoLuong < 50)
            {
                return 50;
            }
            else if (SoLuong < 100)
            {
                return 100;
            }
            else if (SoLuong < 200)
            {
                return 200;
            }
            else
            {
                return SoLuong;
            }
        }
        private double dvgiamoi()
        {
            if (SoLuong < 50)
            {
                return 1000;
            }
            else if (SoLuong < 100)
            {
                return 1200;
            }
            else if (SoLuong < 200)
            {
                return 1500;
            }
            else
            {
                return 2000;
            }
        }
        public double tinhTong()
        {
            double tong = 0;
            double soLuongvuotqua = SoLuong - Soluongtieuchuan();
            if(soLuongvuotqua <= 0)
            {
                tong = SoLuong* SoLuong;
            }
            else
            {
                tong = Soluongtieuchuan() * SoLuong + soLuongvuotqua * dvgiamoi();
            }
            return tong;
        }
    }
}

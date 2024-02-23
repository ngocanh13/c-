using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Nuocngoaicustomer:Customer
    {

        public string quocTich {  get; set; }
        public int SoLuong { get; set; }
        public double dongia { get; set; }
        public Nuocngoaicustomer(string id, string name, DateTime day, string nationality, int quantity, double unitPrice)
        {
            ID = id;
            Name = name;
            Day = day;
            quocTich = nationality;
            SoLuong = quantity;
            dongia = unitPrice;
        }
        public double TinhTong()
        {
           
            return SoLuong * dongia;
        }
    }
}

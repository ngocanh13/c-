using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vncustomer vnCustomer = new Vncustomer("VN001", "Nguyễn Văn A", DateTime.Now, "sinh hoạt", 150, "2000");
            Console.WriteLine("Khách hàng việt nam");
            Console.WriteLine("Tổng cộng " + vnCustomer.tinhTong());

            // Tạo một khách hàng nước ngoài
            Nuocngoaicustomer nuocngoaiCustomer = new Nuocngoaicustomer("FR001", "John Doe", DateTime.Now, "USA", 150, 2000); Console.WriteLine("Foreign Customer: Total Amount: " + nuocngoaiCustomer.TinhTong());

            Console.WriteLine("Khách hàng nước ngoài:");
            Console.WriteLine("Tổng cộng " + nuocngoaiCustomer.TinhTong());
        }
    }
}

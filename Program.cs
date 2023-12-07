using System;
namespace Moneyexchange
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate;//khai bao bien kieu float cho gia tri ti gia VND/USD
            float usd;
          
            Console.Write("Enter rate VND/USD = ");
            rate = float.Parse(Console.ReadLine());//Sử dụng Console.ReadLine() để lấy dữ liệu nhập vào từ người dùng
            Console.Write("Enter USD amount that needed to be exchanged to VND: ");
            usd = float.Parse(Console.ReadLine());//Sử dụng Console.ReadLine() để lấy dữ liệu nhập vào từ người dùng
            float vnd = rate * usd;
            Console.WriteLine("Money in vnd is: " + vnd);
        }
    }
}
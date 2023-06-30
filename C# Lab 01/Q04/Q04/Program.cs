using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    class employee
    {
        double salary;
        double taxrate;
        double taxamount;
        double salaryaftertax;
        public void getdata()
        {
            Console.Write("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your tax rate: ");
            taxrate = Convert.ToDouble(Console.ReadLine());
        }
        public void cal()
        {
            taxamount = salary * taxrate;
            salaryaftertax = salary - taxamount;
            Console.WriteLine("Your salary after tex is: " + salaryaftertax);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.getdata();
            e.cal();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    internal class calcval
    {
        double v;
        double r;
        double h;
        public void getdata()
        {
            r = 7;
            h = 20;
        }
        public double cal()
        {
            v = 22 / 7 * r * r * h;
            return v;
        }
        public void display()
        {
            Console.WriteLine("Radins:{0}", r);
            Console.WriteLine("Height:{0}", h);
            Console.WriteLine("Velume:{0}", v);

        }
    }
    class executevel
    {
        static void Main(string[] args)
        {
            calcval c = new calcval();
            c.getdata();
            c.cal();
            c.display();
            Console.ReadKey();
        }
    }
}

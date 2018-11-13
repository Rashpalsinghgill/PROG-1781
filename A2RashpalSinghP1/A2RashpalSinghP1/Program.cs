using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RashpalSinghP1
{
    class Program
    { 
        static void Main(string[] args)
        {
            double c,d;
            Console.WriteLine("Student's age");
            string ag = Console.ReadLine();
            double age = double.Parse(ag);
            Console.WriteLine("International Student (yes,no)");
            string a = Console.ReadLine();
            Console.WriteLine("Registration Semester (fall, winter, summer)");
            string b = Console.ReadLine();

            if(a=="no")
            {
                if(age<=18)
                {
                    c = 300 + (0.13 * 300);
                    Console.WriteLine("Base Tuition $ " + c);
                }
                else if(age<=49)
                {
                    c = 500 + (0.13 * 300);
                    Console.WriteLine("Base Tuition $ " + c);
                }
                else
                {
                    c = 400 + (0.13 * 400);
                    Console.WriteLine("Base Tuition $ " + c);
                }
            }
            else if(a=="yes")
            {
                if(age<=18)
                {
                    c = 400 + (0.13 * 400);
                    Console.WriteLine("International Student fee " + c);
                }
                else if(age<=49)
                {
                    c=600+(0.13*600);
                    Console.WriteLine("International Student fee " + c);
                }
                else
                {
                    c = 500 + (0.13 * 500);
                    Console.WriteLine("International Student fee " + c);
                }
            }
            switch(b)
            {
                case "fall":
                    {
                        d = 250 + (0.13 * 250);
                        Console.WriteLine("Registration fee for semester $ " + d);
                        double tax = 250 * 0.13;
                        Console.WriteLine("HST $ " + tax);
                        double total = d + tax;
                        Console.WriteLine("total: " + total);
                        break;
                    }
                case "winter":
                    {
                        d = 220 + (0.13 * 220);
                        Console.WriteLine("Registration fee for semester " + d);
                        double tax = 220 * 0.13;
                        Console.WriteLine("HST $ " + tax);
                        double total = d + tax;
                        Console.WriteLine("total: " + total);
                        break;
                    }
                case "summer":
                    {
                        d = 150 + (0.13 * 150);
                        Console.WriteLine("Registration fee for semester " + d);
                        double tax = 150 * 0.13;
                        Console.WriteLine("HST $ " + tax);
                        double total = d + tax;
                        Console.WriteLine("total: " + total);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid month ");
                        break;
                    }
            }
        }
    }
}

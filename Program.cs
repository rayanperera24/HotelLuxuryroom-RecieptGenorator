using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activty_6_Inheritance
{
    class Program
    {
        class room
        {
            protected int feeforaday;
            protected int numberofdaysreserved;



            public void setdata(int f)
            {
                feeforaday = f;

            }

            public void setnumberofdays()
            {
                Console.WriteLine("Enter the number of days");
                numberofdaysreserved = Convert.ToInt32(Console.ReadLine());
            }


            public void displayfeeforaday()
            {
                Console.WriteLine("fee for a day : " + feeforaday);
            }

            public void displaynumberofdaysreserved()
            {
                Console.WriteLine("number of days reserved : " + numberofdaysreserved);
            }

        }

        class luxuryroom : room
        {
            private int servicecharge;

            public void setservicecharge(int s)
            {
                servicecharge = s;
            }


            public void displayservicecharge()
            {
                Console.WriteLine("service charge : " + servicecharge);
            }


            public void calincome()
            {
                Console.WriteLine("income recived from the luxury room is  : " + ((feeforaday * numberofdaysreserved) + servicecharge));
            }

        }
        static void Main(string[] args)
        {
            luxuryroom room1 = new luxuryroom();

            Console.WriteLine();
            Console.WriteLine();
            room1.setdata(150);
            room1.setnumberofdays();
            room1.setservicecharge(100);
            room1.displayfeeforaday();
            room1.displaynumberofdaysreserved();
            room1.displayservicecharge();
            room1.calincome();

            Console.ReadKey();


        }
    }
}

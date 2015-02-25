using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1P1PersonalInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string streetAddress;
            string city;
            string province;
            int age;

            firstName = Convert.ToString("Keshok");
            lastName = Convert.ToString("Sivalingam");
            streetAddress = Convert.ToString("1950 Kennedy Road");
            city = Convert.ToString("Scarborough");
            province = Convert.ToString("Ontario");
            age = 21;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Address: {0}, {1}, {2}", streetAddress, city, province);
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to continue or exit...");
            Console.ReadKey();
        }
    }
}

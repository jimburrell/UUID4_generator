using System;
using System.Diagnostics;

namespace SampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidAsString = myuuid.ToString();

            Console.WriteLine("Your UUID is: " + myuuidAsString);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press ENTER to EXIT");
            Console.Read();  
        }
    }
}
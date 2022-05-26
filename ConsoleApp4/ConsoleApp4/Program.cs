using System;
using ConsoleApp4.Models;
using ConsoleApp4.Services;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = new Xml();
            var result = xml.Deserialize();
            //
            // var document = new Document_Order
            // {
            //     OrderHeader = new Order_Header
            //     {
            //         OrderDate = DateTime.Now,
            //         OrderNumber = "dasd20202"
            //     }
            // };
            //
            // xml.Serialize(@"C:\TMP\xml1\document1.xml", document);

            var result2 = xml.DeserializeAll();

           

            Console.WriteLine(result.OrderHeader.OrderDate);
            Console.WriteLine(result.OrderHeader.OrderNumber);
        }
    }
}

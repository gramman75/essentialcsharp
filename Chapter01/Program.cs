using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter01
{
    class PdaItem
    {
        

        public string Name { get; set; } = "Gramman Name";
        public string ID { get; set; } = "123456";
   
        public virtual void PrintDeviceName()
        {
            Console.WriteLine($"PDA Device Name={Name}");

        }
    }

    class Contact : PdaItem
    {
        public void PrintAddress()
        {
            Console.WriteLine("Address");
        }

        public override void PrintDeviceName()
        {
            Console.WriteLine("Contact overried");
        }
    }



    static class Program
    {
        public static void PrintDeviceID(this PdaItem item)
        {
            Console.WriteLine($"PDA Device ID={item.ID}");
        }

        static void Main(string[] args)
        {

            Contact contact = new Contact();

            contact.PrintDeviceName();

            contact.PrintDeviceID();
        }
    }
}

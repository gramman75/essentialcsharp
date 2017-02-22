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
            Console.ReadLine();

            Contact contact = new Contact();

            contact.PrintDeviceName();

            contact.PrintDeviceID();
        }

        
    }

    public abstract class Sample: ITest{
        // abstact 형한정자가 선언이되면 구현을 하지 않아도 됨.
        public abstract int Test1();
        // abstract 형한저자가 없으면 아래와 같이 exception이라도 구현해야 함.
        public int Test2()
        {
            throw new NotImplementedException();
        }
            
    }


    interface ITest
    {
        int Test1();
        int Test2();        

    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overriding
{
    public class BaseClass
    {
        public void DisplayName()
        {
            Console.WriteLine("BaseClass");
        }
    }

    public class DerivedClass : BaseClass
    {
        // Compiler WARNING: DisplayName() hides inherited
        // member. Use the new keyword if hiding was intended.
        new public virtual void DisplayName()
        {
            Console.WriteLine("DerivedClass");
        }
    }

    public class SubDerivedClass : DerivedClass
    {
        public override void DisplayName()
        {
            Console.WriteLine("SubDerivedClass");
        }
    }
    public class SuperSubDerivedClass : SubDerivedClass
    {
        public new void DisplayName()
        {
            Console.WriteLine("SuperSubDerivedClass");
        }
    }

    public class Program
    {
        public static void Main()
        {
            SuperSubDerivedClass superSubDerivedClass = new SuperSubDerivedClass();
            SubDerivedClass subDerivedClass = superSubDerivedClass;
            DerivedClass derivedClass = superSubDerivedClass;
            BaseClass baseClass = superSubDerivedClass;

            superSubDerivedClass.DisplayName();
            subDerivedClass.DisplayName();
            derivedClass.DisplayName();
            baseClass.DisplayName();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueVSReference
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is created on the stack...
            SomeValueType v1 = new SomeValueType();
            //this is created on the heap...
            SomeRefType r1 = new SomeRefType();
            v1.x = 5;
            r1.x = 5;

            Console.WriteLine("v1.x = {0}", v1.x);
            Console.WriteLine("r1.x = {0}", r1.x);

            //allocate on stack and copies members
            SomeValueType v2 = v1;
            //copies reference only
            SomeRefType r2 = r1;
            Console.WriteLine("Copied r1 to r2, v1 to v2...");

            Console.WriteLine("v2.x = {0}", v2.x);
            Console.WriteLine("r2.x = {0}", r2.x);

            r2.x = 8; //this will change both r1 and r2
            v2.x = 8; //this will only change v2
            Console.WriteLine("Changed r2 and v2...");

            Console.WriteLine("v1.x = {0}", v1.x);
            Console.WriteLine("v2.x = {0}", v2.x);
            Console.WriteLine("*******************");
            Console.WriteLine("r1.x = {0}", r1.x);
            Console.WriteLine("r2.x = {0}", r2.x);


        }
    }



    /**
 * A really simple value type...
 */
    public struct SomeValueType
    {
        public int x;
    }

    /**
     * A really simple reference type...
     */
    public class SomeRefType
    {
        public int x;
    }
}

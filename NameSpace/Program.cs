//using NameSpace.A.B.C;


namespace NameSpace
{
    //using A.B.C; // using "using at the very top of file"
    using D = A.B.C; // creating alias for the namespace A.B.C (which specifies class in folder A/B/C)
    
    class Program
    {
        static void Main(string[] args)
        {
       
            //now can use SomeClass
            //SomeClass cls = new SomeClass(); // using "using at the very top of file"
            
            // instanciate class using namespace alias D
            D.SomeClass cls = new D.SomeClass();
            cls.LoastAndFound();
        }

    }

}

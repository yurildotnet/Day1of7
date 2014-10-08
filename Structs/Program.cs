using System;


/*
 This code demonstrates that Structs are Value Type:

1. loc1 created and initialized with 200 and 300

2. This loc1 object is passed to the myFunc() method to the myFunc() method  - t.myFunc(loc1)

3. In myFunc(), new values are assigned to x and y , and these new values are printed:
Loc1 location: 50, 100
 
4. When you return to the calling function Main() and call WriteLine() again, the values are unchanged(!!!):
Loc1 location: 200, 300

The struct was passed as a value object, and a copy was made in myFunc()
 
 
 */



namespace Structs
{
    public struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
     
        public override string ToString()
        {
            return (String.Format("{0}, {1}", X, Y));
        }
            
     }
    


    class Tester
    {

        public void myFunc(Location loc)
        {
            loc.X = 50;
            loc.Y = 100;
            Console.WriteLine("In MyFunc loc: {0}", loc);
        }    
        
        
        
        static void Main(string[] args)
        {
            Location loc1 = new Location();
            loc1.X = 200;
            loc1.Y = 300;
            Console.WriteLine("Loc1 location: {0}", loc1);

            Tester t = new Tester();
            t.myFunc(loc1);
            Console.WriteLine("Loc1 location: {0}", loc1);


           

        }
    }
}

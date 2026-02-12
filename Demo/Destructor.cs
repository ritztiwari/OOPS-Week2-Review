using System;

public partial class Destructor
    {
       public Destructor()
        {
            Console.WriteLine("Destructor called");
        }
    public static void Main1()
    {
        Console.WriteLine("In Main1 Method");
        
    }

    }   


    public partial  class Destructor
    {
        public  void Main()
        {
            // Third obj = new Third();
            // obj = null;
            // GC.Collect();
            Main1();
           Console.WriteLine("In Main Method");
            // Console.ReadKey();
            
        }
    
    }

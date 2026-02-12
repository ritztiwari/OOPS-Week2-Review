
namespace Practice02
{
    using Events;
    using Delegat;
using Att;

[Attributes("sohil")]
    public class Program
    {
        // public delegate void Mydel();
        // public delegate void MydelWithString(string str);

        public static void Main(string[] args)
        {
            // Delegatess del = new Delegatess();

            // // Delegate with no parameters
            // Mydel mydel = new Mydel(del.Fun1);
            // mydel();
            // mydel();

            // // Delegate with string parameter
            // MydelWithString mydel1 = new MydelWithString(del.Fun2);
            // mydel1("Sohil");
            // mydel1("Again");

        //    EventExample example = new EventExample();
        //     example.RaiseEvent("Sohil", "Copilot");

        // Test.Run();

        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance("Second Instance");

        }
    }
}

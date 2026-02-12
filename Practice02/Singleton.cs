public class Singleton
{
    private static Singleton instance;
    private Singleton()
    {
Console.WriteLine("Singleton without parameters");
    }
    
    private Singleton(string name)
    {
Console.WriteLine("Singleton with string parameter: " + name);
    }
    public static Singleton GetInstance(string name=null )
    {
        // if (instance == null)
        // {
            if (name != null)
            {
                instance = new Singleton(name);
            }
            else
            {
                instance = new Singleton();
            }
        // }
        return instance;
    }
    
}
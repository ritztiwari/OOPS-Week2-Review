using System;
using Practice02;

namespace Att{
public class Test
{
   public  static void Run()
    {
        var type = typeof(Program);
        var attrs = type.GetCustomAttributes(false);

        foreach (var attr in attrs)
        {
            if (attr is Att.AttributesAttribute myAttr)
            {
                Console.WriteLine($"Attribute Name: {myAttr.Name}");
            }
        }
    }
}
}
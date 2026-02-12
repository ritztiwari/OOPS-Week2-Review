using System;
namespace Att
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
 sealed class AttributesAttribute : Attribute
    {
     public  string Name{get;set;}
      public  AttributesAttribute(String name)
        {
            Name=name;
        }
    }
    

}
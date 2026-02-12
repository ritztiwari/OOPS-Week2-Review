using System;
public class Node
{
    public String Name;
    public int Id;
    public int Age;
    public Node Next;
    public Node(String name, int id, int age)
    {
        this.Name = name;
        this.Id = id;
        this.Age = age;
        this.Next = null;
    }
    public void display()
    {
        Console.WriteLine("Name: " + Name + ", Id: " + Id + ", Age: " + Age);
    }


}
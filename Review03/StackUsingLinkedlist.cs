//implement a stack using linked list in C# with a method to delete the middle element of the stack.
using System;
public class Node
{
  public  String val;
  public  int data;
   public Node next;
    public Node(int data,String s)
    {
        this.data = data;
        this.val = s;
        next = null;
    }

} 
public class Stack
{
    public Node top;
    public int count=0;
    public int limit =10;

    public void Push(int data,String s)
    {
        if (count < limit)
        {
            
            Node nn = new Node(data,s);
            nn.next = top;
            top = nn;
            count++;
        }
        else
        {
            Console.WriteLine("Stack overflow");
        }
        limit = count < limit ? limit : limit * 2;
    }

    public void PrintStack()
    {
        Node cur = top;

        while (cur!=null){
        Console.WriteLine(cur.data+" => "+cur.val);
        cur=cur.next;

       }

    }
    public void DeleteMiddle()
    {
        
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Node temp = null;
        Node crr = top;
        int mid = count / 2;
        for(int i = 0; i < mid ; i++)
        {
            temp= crr;
            crr = crr.next;
            
         
        }
        if (temp != null) { 
            temp.next = crr.next;
            count--;
        }
       
    }

}


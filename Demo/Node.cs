using System;
public class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public  class List
{
    private Node head;
    public  void addNode (int data)
    {
        Node nn=new Node(data);
        if(head==null)
        {
            head=nn;
        }
        else
        {
            Node temp=head;
            while(temp.Next!=null)
            {
                temp=temp.Next;
            }
            temp.Next=nn;
    }
    }
    public  void printList()
    {
        Node temp=head;
        while(temp!=null)
        {
            Console.Write(temp.Value + " ");
            temp=temp.Next;
        }
    }

}
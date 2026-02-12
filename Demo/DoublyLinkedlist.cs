using System;
using System.Runtime.InteropServices;

public class DNode
{
   public int data;
    public DNode next;
    public DNode prev;
    public DNode(int data)
    {
        this.data = data;
        next = null;
        prev = null;
    }


}
public class Doubly
{
    private DNode head;  
    private DNode tail;
    public void AddNode(int data)
    {
        DNode nn = new DNode(data);
        if (head == null)
        {
            head = nn;
            tail = nn;
            //head = nn;
        }
        else
        {
            tail.next = nn;
            nn.prev = tail;
            tail = nn;
        }
}

    
    public void Print()
    {
       DNode cur = head;
        while (cur != null)
        {
            Console.Write(cur.data);
    cur = cur.next;

        }
    }
    public void PrintReverse()
    {
        DNode cur = tail;
        while (cur != null)
        {
            Console.Write(cur.data);
            cur = cur.prev;
        }
    }

}
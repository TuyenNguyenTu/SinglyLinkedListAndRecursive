using System;
namespace DanhSachLienKetDon
{
  public class Node
  {
    public int data;
    public Node next;
    public Node(int i)
    {
      data = i;
      next = null;
    }
    public void AddSorted(int data)
    {
      if (next == null)
      {
        next = new Node(data);

      }
      else if (data < next.data)
      {
        Node temp = new Node(data);
        temp.next = this.next;
        this.next = temp;
      }
      else
      {
          next.AddSorted(data);
      }
    }
    //recursive
    public void Print()
    {
      System.Console.Write("==>" + data);
      if (next != null)
      {
        next.Print();
      }
    }
    //recursive
    public void AddToEnd(int number)
    {
      if (next == null)
      {
        next = new Node(number);
      }
      else
      {
        next.AddToEnd(number);
      }
    }
  }
}
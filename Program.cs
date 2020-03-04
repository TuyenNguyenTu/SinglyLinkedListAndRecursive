using System;

namespace DanhSachLienKetDon
{
  class Program
  {
    public static void DeQuy(int i)
    {
      if (i == 1)
      {
        Console.WriteLine("Dit me viet");
      }
      else
      {
        Console.WriteLine("Dit me viet");
        DeQuy(i - 1);

      }
    }
    static void Main(string[] args)
    {
      // Node myNode = new Node(7);
      // myNode.next = new Node(10);
      // myNode.AddToEnd(5);
      // myNode.AddToEnd(2);
      // myNode.AddToEnd(11);
      // myNode.AddToEnd(8);
      // myNode.Print();

      MyList list = new MyList();
      list.AddToEnd(10);
      list.AddToEnd(20);
      list.AddToBegin(2);
      list.Print();


    }
  }
}

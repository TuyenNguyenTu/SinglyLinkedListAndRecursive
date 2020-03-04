namespace DanhSachLienKetDon
{
  public class MyList
  {
    public Node headNode;
    public MyList()
    {
      headNode = null;
    }
    //recursive
    public void AddToEnd(int data)
    {
      if (headNode == null)
      {
        headNode = new Node(data);
      }
      else
      {
        headNode.AddToEnd(data);
      }
    }
    public void AddToBegin(int data)
    {
      if (headNode == null)
      {
        headNode = new Node(data);
      }
      else
      {
        Node temp = new Node(data);
        temp.next = headNode;
        headNode = temp;

      }
    }
    public void AddSorted(int data)
    {
      if (headNode == null)
      {
        headNode = new Node(data);
      }
      else if (data < headNode.data)
      {
        AddToBegin(data);
      }
      else
      {
          headNode.AddSorted(data);
      }
    }
    public void Print()
    {
      if (headNode != null)
      {
        headNode.Print();
      }
    }
  }
}
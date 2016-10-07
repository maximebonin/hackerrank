  public static Node removeDuplicates(Node head)
  {
      Node temp = head;
      
      while(temp.next != null)
      {
          while(temp.data == temp.next.data)
          {
              if(temp.next.next != null)
              {
                   temp.next = temp.next.next;
              }
              else
              {
                  temp.next = null;
                  return head;
              }
          }
          temp = temp.next;
          
      }
      return head;
  }
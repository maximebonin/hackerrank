/*
  Insert Node at the begining of a linked list
  Initially head pointer argument could be NULL for empty list
  Node is defined as 
  struct Node
  {
     int data;
     struct Node *next;
  }
return back the pointer to the head of the linked list in the below method.
*/
Node* Insert(Node *head,int data)
{
    Node* newHeadNode = new Node();
    newHeadNode->data = data;
    newHeadNode->next = NULL;

    if(head != NULL)
    {
       newHeadNode->next = head;
    }
    
    return newHeadNode;
}d
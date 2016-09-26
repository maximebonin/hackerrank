Node* Insert(Node *head,int data)
{
    Node* newNode = new Node();
    newNode->data = data;
    newNode->next = NULL;
    
    if(head == NULL)
    {
        head = newNode;
        
        return head;
    }
    else
    {
        Node* duplicateNode = head;
        
        while(true)
        {
            if(duplicateNode->next == NULL)
            {
                duplicateNode->next = newNode;
                break;
            }
            else
            {
                duplicateNode = duplicateNode->next;
            }
        }
        
        return head;
    }    
}
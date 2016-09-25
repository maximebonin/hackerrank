void Print(Node *head)
{
    if(head != NULL)
    {
        std::cout << head->data << endl;
        Print(head->next);
    }
}
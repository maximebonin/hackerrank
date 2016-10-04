    static void levelOrder(Node root)
    {
        if(root != null)
        {
            Queue<Node> file = new Queue<Node>();
            
            file.Enqueue(root);
            
            while(file.Count != 0)
            {
                Node arbre = file.Dequeue();
                
                Console.Write(arbre.data+" ");
                
                if(arbre.left != null)
                {
                    file.Enqueue(arbre.left);
                }
                if(arbre.right != null)
                {
                    file.Enqueue(arbre.right);
                }
            }
        }
    }
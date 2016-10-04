public static int longuest = -9999;
    public static bool rightDone = false;
    
    static Node getLeftNode(Node p_Root)
    {
        return p_Root.left;
    }
    static Node getRightNode(Node p_Root)
    {
        return p_Root.right;
    }

    static int getHeight(Node root)
    {       
        int actualLenght = 0;
        Node tempRoot = root;
        
        if(rightDone)
        {
              while((getLeftNode(tempRoot)!=null)||(getRightNode(tempRoot)!=null))
            {
                actualLenght++;
            
                if(getLeftNode(tempRoot)!=null)
                {
                    tempRoot = getLeftNode(tempRoot);
                }
                else
                 {
                    tempRoot = getRightNode(tempRoot);
                 }
            }
        }
        else
        {
              while((getLeftNode(tempRoot)!=null)||(getRightNode(tempRoot)!=null))
            {
                actualLenght++;
            
                if(getRightNode(tempRoot)!=null)
                {
                    tempRoot = getRightNode(tempRoot);
                }
                else
                 {
                    tempRoot = getLeftNode(tempRoot);
                 }
            }
        }
        
      
        
        if(actualLenght > longuest)
        {
            longuest = actualLenght;
        }
        if(rightDone)
        {
            getHeight(root);
        }
        
        
    
        
        
        return longuest;
    }

// recursion ... !

public static int getHeight(Node p_Root)
{
    if(p_Root == null)
    {
        return -1;
    }
    
        return 1 + Math.Max(getHeight(p_Root.left), getHeight(p_Root.right));
    
}
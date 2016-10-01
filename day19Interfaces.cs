​class Calculator : AdvancedArithmetic
{
    public int divisorSum(int p_N)
    {
        int sum = 0;
        
        for(int i = 1 ; i <= p_N ; i++)
        {
            if((p_N % i) == 0)
            {
                sum += i;
            }
        }
        
        return sum;
    }
}​
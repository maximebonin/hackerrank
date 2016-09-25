    public Difference(int[] p_Elements)
    {
        this.elements = p_Elements;
        this.maximumDifference = -1;
    }

    public void computeDifference()
    {
        for(int i = 0 ; i < this.elements.Length ; i++)
        {
            int difference;
            for(int j = 0 ; j < this.elements.Length ; j++)
            {
                difference = this.elements[i] - this.elements[j];
                difference = Math.Abs(difference);
                
                if(difference > maximumDifference)
                {
                    maximumDifference = difference;
                }
            }
        }
    }
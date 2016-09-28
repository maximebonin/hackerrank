​  class Calculator
   {
     int result = 0;
     
     public int power(int p_A, int p_B)
     {
         if(p_A>=0 && p_B>=0)
         {
             double a = Convert.ToDouble(p_A);
             double b = Convert.ToDouble(p_B);
             double resultDouble = Math.Pow(a, b);
             result = Convert.ToInt32(resultDouble);
          }
         else
         {
        	throw new System.ArgumentException("n and p should be non-negative");
		}
         
		return result;
     }
     
   }
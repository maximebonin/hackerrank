/* 

I didn't bother reinventing the wheel. 
Just use C#'s built-in Stack/Queue methods/
data structures

*/


class Solution {

    public Stack<char> m_Stack = new Stack<char>();
    public Queue<char> m_Queue = new Queue<char>();
    
   

    
    public void pushCharacter(char p_Char)
    {
        this.m_Stack.Push(p_Char);
    }
    public void enqueueCharacter(char p_Char)
    {
        this.m_Queue.Enqueue(p_Char);
    }
    public char popCharacter()
    {
        return this.m_Stack.Pop();
    }
    public char dequeueCharacter()
    {
        return this.m_Queue.Dequeue();
    }
class MyBook : Book
{
    public int m_Price;
    
    public MyBook(string p_Title, string p_Author, int p_Price) : base(p_Title, p_Author)
    {
        
        this.m_Price = p_Price;
    }
    
    public override void display()
    {
        Console.WriteLine("Title: "+this.title);
        Console.WriteLine("Author: "+this.author);
        Console.WriteLine("Price: "+this.m_Price);
    }
}
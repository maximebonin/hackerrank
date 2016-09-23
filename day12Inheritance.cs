class Student : Person
{
    private int[] testScores;
    private enum lettre{O = 0, E=1, A=2, P=3, D=4, T=5 };
    private lettre m_Grades;
    
    
    public Student(string p_Firstname, string p_Lastname, int p_Id, int[] p_Scores)
    {
        this.firstName = p_Firstname;
        this.lastName = p_Lastname;
        this.id = p_Id;
        this.testScores = p_Scores;
    }
    
    public string calculate()
    {
        int noteMoyenne = moyenne();
        string reponse = "";
        
        whichGrade(noteMoyenne);
        
        switch(this.m_Grades)
        {
            case lettre.O : reponse = "O";
                break;
            case lettre.A : reponse = "A";
                break;
            case lettre.D : reponse = "D";
                break;
            case lettre.E : reponse = "E";
                break;
            case lettre.P : reponse = "P";
                break;
            case lettre.T : reponse = "T";
                break;
        }
        
        return reponse;
        
        
    }
    
    private int moyenne()
    {
        int somme =0;
        
        for(int i = 0 ; i < this.testScores.Length ; i++)
        {
            somme += this.testScores[i];
        }
        
        return somme / this.testScores.Length;
    }
    
    private void whichGrade(int p_Grade)
    {
        if(p_Grade < 40)
        {
            this.m_Grades = Student.lettre.T;
        }
        else if((p_Grade >= 40)&&(p_Grade <55))
        {
            this.m_Grades = Student.lettre.D;
        }
        else if((p_Grade >=55)&&(p_Grade <70))
        {
            this.m_Grades = Student.lettre.P;
        }
        else if((p_Grade >=70)&&(p_Grade < 80))
        {
            this.m_Grades = Student.lettre.A;
        }
        else if((p_Grade >=80)&&(p_Grade<90))
        {
            this.m_Grades = Student.lettre.E;
        }
        else
        {
            this.m_Grades = Student.lettre.O;
        }
    }
  
}​
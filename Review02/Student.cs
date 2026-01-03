using System;

public class Student : User
{
    public string Name { get; set; }
    public int Id { get; private set; }
    public int Marks { get; private set; }

    public Student(string name, int id, int marks)
    {
        Name = name;
        Id = id;
        Marks = marks;
    }
    public override int CreditCalculation()
    {
       if(Marks >=80 && Marks <= 100)
        {
            return 5;
        }else if(Marks >= 60 && Marks < 80)
        {
            return 4;
        }
        else if(Marks >= 50 && Marks < 60)
        {
            return 3;
        }
        else if(Marks >= 40 && Marks < 50)
        {
            return 2;
        }
        else
        {
            return 0; 

        }
       

       
    }
    ~Student() { }

}

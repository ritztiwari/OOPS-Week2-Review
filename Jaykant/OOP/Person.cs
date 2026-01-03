namespace OOP;

abstract class Person
{
    private int internalMarks;
    private int externalMarks;

    public int InternalMarks
    {
        get { return internalMarks; }
        set { internalMarks = value; }
    }

    public int ExternalMarks
    {
        get { return externalMarks; }
        set { externalMarks = value; }
    }

    public Person(int internalMarks, int externalMarks)
    {
        this.internalMarks = internalMarks;
        this.externalMarks = externalMarks;
    }

    public int TotalMarks()
    {
        return internalMarks + externalMarks;
    }

    public abstract void GradeCalculation();

    public void DisplayInfo()
    {
        Console.WriteLine("Information about Marks");
        Console.WriteLine($"Internal Marks: {internalMarks}");
        Console.WriteLine($"External Marks: {externalMarks}");
    }
}

class Student : Person
{
    public string name;
    public int rollNo;

    public Student(int internalMarks, int externalMarks, string name, int rollNo) : base(internalMarks, externalMarks)
    {
        this.name = name;
        this.rollNo = rollNo;
    }


    public override void GradeCalculation()
    {

        if (TotalMarks() > 90)
        {
            Console.WriteLine("Grade is A");
        }
        else if (TotalMarks() >= 80 && TotalMarks() < 90)
        {
            Console.WriteLine("Grade is B");
        }
        else
        {
            Console.WriteLine("Grade is C");
        }
    }

    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine();
        Console.WriteLine("Student Information");
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student rollNo: {rollNo}");
    }

    ~Student()
    {

        Console.WriteLine("EvaluationEngine resource management");
    }

}
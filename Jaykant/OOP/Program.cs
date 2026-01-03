namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        static void CreateStudent()
        {
            Student s1 = new Student(40, 55, "Arjun", 1201);
            s1.DisplayInfo();
            s1.GradeCalculation();
        }

        // Object Call
        CreateStudent();

        GC.Collect();

        Console.ReadKey();
    }
}

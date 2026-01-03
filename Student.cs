class Student : User
{
	private int marks;
	private int credits;

	public Student(string name, int id, int marks)
		: base(name, id)
	{
		this.marks = marks;
	}

	public override string GetRole()
	{
		return "Student";
	}

	public void CalculateCredits()
	{
		if (marks >= 85)
			credits = 4;
		else if (marks >= 70)
			credits = 3;
		else if (marks >= 50)
			credits = 2;
		else
			credits = 0;
	}

	public int GetCredits()
	{
		return credits;
	}

	public string GetStudentDetails()
	{
		return $"Name: {Name}, ID: {Id}, Marks: {marks}, Credits: {credits}";
	}
}

using System.Collections.Generic;

class University
{
	private List<Student> students = new List<Student>();

	public void EnrollStudent(Student student)
	{
		students.Add(student);
	}
	public List<Student> GetStudents()
	{
		return students;
	}
}

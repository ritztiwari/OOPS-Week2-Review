/*using System;

class Program
{
	static void Main()
	{
		Student student = new Student("lucky Goyal", 811, 78);
		University university = new University();

		university.EnrollStudent(student);

		using (AcademicEngine engine = new AcademicEngine())
		{
			engine.EvaluateStudent(student);
			Console.WriteLine(student.GetStudentDetails());
		}

	}
}
*/


using System;

class Program
{
	static void Main()
	{
		string s = "()())()"; 
		string[] results = RemoveInvalid(s);
		foreach (string st in results)
		{
			if (st != null)  
				Console.WriteLine(st);
		}
	}

	static string[] RemoveInvalid(string s)
	{
		string[] res = new string[10];  
		int count = 0;
		for (int i = 0; i <= s.Length; i++)
		{
			for (int j = 0; j < s.Length; j++)
			{
				if (s[j] != '(' && s[j] != ')') continue;
				string t = s.Remove(j, 1);
				if (IsValid(t))
				{
					bool exists = false;
					for (int k = 0; k < count; k++)
						if (res[k] == t) exists = true;
					if (!exists)
						res[count++] = t;
				}
			}
		}
		return res;
	}
	static bool IsValid(string s)
	{
		int balance = 0;
		foreach (char c in s)
		{
			if (c == '(') balance++;
			if (c == ')') balance--;
			if (balance < 0) return false;
		}
		return balance == 0;
	}
}

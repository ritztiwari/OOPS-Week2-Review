using System;

class AcademicEngine : IDisposable
{
	private bool disposed = false;

	public void EvaluateStudent(Student student)
	{
		student.CalculateCredits();
		Console.WriteLine("credit evaluation");
	}

	public void Dispose()
	{
		Cleanup();
		GC.SuppressFinalize(this);
	}

	private void Cleanup()
	{
		if (!disposed)
		{
			Console.WriteLine("Acaddemic files deleted");
			disposed = true;
		}
	}

	~AcademicEngine()
	{
		Cleanup();
	}
}

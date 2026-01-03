abstract class User
{
	protected string Name;
	protected int Id;

	public User(string name, int id)
	{
		Name = name;
		Id = id;
	}

	public abstract string GetRole();
}

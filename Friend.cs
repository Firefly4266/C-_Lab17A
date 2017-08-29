// Friend.cs

// Todo:  need to put the proper 'using' directives here

public class Friend
// todo: What interface needs to be implemented?
{
	public Friend(string name, string spouse)
	{
		name_ = name;
		spouse_ = spouse;
	}
	public override string ToString()
	{
		string val = string.Format("Friend: {0,20}, Spouse{1,20}",name_, spouse_);
		return val;
	}
	public string Name
	{
		get{return name_;}
	}
	public string Spouse
	{
		get{return spouse_;}
	}
// todo:  What methods are required to implement necessary interface?

	private string name_;
	private string spouse_;
}

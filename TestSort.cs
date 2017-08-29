// TestSort.cs

using System;
using System.Collections;

class TestSort
{
	static void Main(string[] args)
	{
		InputWrapper iw = new InputWrapper(); 
		string name = " ";
		string spouse;
		ArrayList MyMarriedFriends = new ArrayList();
		while(true)
		{
			Console.WriteLine("Enter friend's name, quit to exit");
			name = iw.getString("> ");
			if(name.Equals("quit"))
				break;
			Console.WriteLine("Enter friend's spouse's name");
			spouse = iw.getString("> ");
			Friend node = new Friend(name, spouse);
			MyMarriedFriends.Add(node);
		}
		foreach(object o in MyMarriedFriends)
		{
		// todo: what errors need to be handled here?
			Friend f = (Friend) o;
			Console.WriteLine(f.ToString());
		}
		MyMarriedFriends.Sort(); // default sort
		Console.WriteLine("\nSorted");
		foreach(object o in MyMarriedFriends)
		{
		// todo: what errors need to be handled here?
			Friend f = (Friend) o;
			Console.WriteLine(f.ToString());
		}
		Console.Write("Enter <cr> to end program");
		Console.ReadLine();
	}
}


// Friend.cs
using System;
using System.Collections;
using System.Runtime.InteropServices;

// Todo:  need to put the proper 'using' directives here

public class Friend : IComparable
// todo: What interface needs to be implemented?
{
    public Friend(string name, string spouse)
    {
        name_ = name;
        spouse_ = spouse;
    }
    public override string ToString()
    {
        string val = string.Format("Friend: {0,20}, Spouse{1,20}", name_, spouse_);
        return val;
    }
    public string Name
    {
        get { return name_; }
    }
    public string Spouse
    {
        get { return spouse_; }
    }
    // todo:  What methods are required to implement necessary interface?
    public int CompareTo(object obj)
    {
        if (obj == null)
        {

            throw new Exception("This is not a valid object");
        }
        return name_.CompareTo(obj);
    }

    private string name_;
    private string spouse_;

    public int Compare(object x, object y)
    {
        Friend X = x as Friend;
        Friend Y = y as Friend;
        if (X == null || Y == null)
        {
            throw new Exception("Invalid comparison.");
        }
        return X.Spouse.CompareTo(Y.Spouse);
    }
}

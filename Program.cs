/*
 * Implemented Single Responsiblity
 * Implemented
 */
using System;

public class Program
{
	
	public static void Main()
	{
		Computer computer1 = new Computer();
		computer1.TestComputer();
		Mobile mobile1 = new Mobile();
		mobile1.TestMobile();
	}
}

public interface IDevice
{
	
	public string WritingData() //Harddrive
	{
		return "Writing Data";
	}	


	public string StoringData() //RAM
	{
		return "Storing Data";
	}

public string Calculate();
	public string Motherboarding();
		
}
public interface IComputer
{
	
	public string ProducePower()
	{
	return "Producing Power";
	}
	
}
public interface IMobile
{
	public string DisplayData()
	{
		return "Displaying Data";
	}
	public string ProduceBattery()
	{
		return "Charging Battery";
	}
}
public class Computer : IDevice , IComputer
{
	public string Calculate()
    {
        throw new NotImplementedException();
    }

    public string Motherboarding()
    {
        throw new NotImplementedException();
    }

    public string ProducePower()
    {
        
		return "Producing Power";
	}

    public string StoringData()
    {
		return "Writing Data";
	}

    public void TestComputer()
	{
		Console.WriteLine(this.Motherboarding());
		Console.WriteLine(this.Calculate());
		Console.WriteLine(this.StoringData());
		Console.WriteLine(this.WritingData());
		Console.WriteLine(this.ProducePower());
	}

    public string WritingData()
    {
        throw new NotImplementedException();
    }
}

public class Mobile : IDevice, IMobile
{
    public string Calculate()
    {
        throw new NotImplementedException();
    }

    public string Motherboarding()
    {
        throw new NotImplementedException();
    }

    public string ProduceBattery()
    {
        throw new NotImplementedException();
    }
	public string DisplayData()
	{
		throw new NotImplementedException();
	}
	public void TestMobile()
	{
		Console.WriteLine(this.Motherboarding());
		Console.WriteLine(this.Calculate());
		//Console.WriteLine(this.StoringData());
		//Console.WriteLine(this.WritingData());
		Console.WriteLine(this.DisplayData());
		Console.WriteLine(this.ProduceBattery());
	}
}



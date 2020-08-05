using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Number of leaves required .");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number of available leaves .");
        int a = Convert.ToInt32(Console.ReadLine());

        applyLeaves bl = new applyLeaves(l,a);
        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
        bl.check();
    }

    // event handler
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Confirm please(Y/N)");
        String temp = Console.ReadLine();
        if (temp.Equals("Y"))
        {
            Console.WriteLine("Mail send to the manager..");
        }
        else
        {
            Console.WriteLine("Leave application cancelled");
        }
        Console.ReadLine();
    }
}

public delegate void Notify();  // delegate

public class applyLeaves
{
    public event Notify ProcessCompleted; // event
    public int NoOfLeaves;
    public int AvailLeaves;

    public applyLeaves(int l,int a)
    {
        NoOfLeaves = l;
        AvailLeaves = a;
    }


    public void check()
    {
        Console.WriteLine("Leave application process Started!");
        if(AvailLeaves >= NoOfLeaves)
        {
            ProcessCompleted?.Invoke();
        }
        else
        {
            Console.WriteLine("Leaves not available.");
        }
    }


    
}
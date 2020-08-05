using System;
using System.IO;

namespace Program
{

    public class ProcessEventArgs : EventArgs
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }

    public class ProcessBusinessLogic
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<ProcessEventArgs> ProcessCompleted;


        public void StartProcess()
        {
            var data = new ProcessEventArgs();

            try
            {
                Console.WriteLine("Enter first number:");
                int temp1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int temp2 = Convert.ToInt32(Console.ReadLine());
                data.Number1 = temp1;
                data.Number2 = temp2;
                Console.WriteLine("Press Enter to add  ");
                ConsoleKeyInfo keyinfo;
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    OnProcessCompleted(data);
                }
                else
                {
                    Console.WriteLine("you didnt Press Enter!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }

    }

    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        //// event handler
        public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine(e.Number1 + e.Number2);
        }

    }

}

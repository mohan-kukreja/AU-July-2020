using System;

namespace Program
{
    public delegate void TaskCompleted(string taskResult);
    public class CallBack
    {
        public void Task(TaskCompleted taskCompleted)
        {
            Console.WriteLine("starting task");
            if (taskCompleted != null)
                taskCompleted("task completed");
        }
    }
    public class CallBackTest
    {
        public void Test()
        {
            TaskCompleted callback = TestCallBack;
            CallBack testCallBack = new CallBack();
           
            testCallBack.Task(callback);
            
        }
        public void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CallBackTest callBackTest = new CallBackTest();
            callBackTest.Test();
            Console.ReadLine();
        }
    }
}

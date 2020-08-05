using System;  // C# , ADO.NET  
using DT = System.Data;            // System.Data.dll  
using QC = Microsoft.Data.SqlClient;  // System.Data.dll  


namespace AU_Accolite
{
    class Program
    {
        public delegate int countChar(string a, string b);

        public static int countCR(string a, string b)
        {
            String c = a + b;
            return c.Length;
        }

        static void Main(string[] args)
        {
            countChar cr = new countChar(countCR);
            String a = "mohan";
            String b = "kukreja";
            Console.WriteLine(a + " " + b);
            Console.WriteLine(cr(a, b));

            


		}
    }
}

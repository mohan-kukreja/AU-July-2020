using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Net_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
             
              
            String[] Student = {"mohan","reema","seema","nirma","jaya","shushma"};
        
           
            var result = from s in Student 
                      where s.Contains("ee") 
                      select s; 
      
           
            foreach(var it in result) 
            { 
                Console.WriteLine(it); 
            } 
           
        }
    }
}

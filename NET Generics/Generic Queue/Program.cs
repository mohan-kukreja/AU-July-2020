using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Net_Practice
{
   public class footballer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
    }
    
    public class demo{
        static void Main(string[] args)
        {
            footballer fb1 = new footballer(){
                ID= 7,
                Name= "Cristiano Ronaldo",
                Position= "LW",
                Age= 35
            };
            footballer fb2 = new footballer(){
                ID= 10,
                Name= "Lionel Messi",
                Position= "CAM",
                Age= 33
            };
            footballer fb3 = new footballer(){
                ID= 4,
                Name= "Sergio Ramos",
                Position= "CB",
                Age= 35
            };
            footballer fb4 = new footballer(){
                ID= 10,
                Name= "Eiden Hazard",
                Position= "ST",
                Age= 27
            };
            Queue<footballer> q = new Queue<footballer>();
            q.Enqueue(fb1);
            q.Enqueue(fb2);
            q.Enqueue(fb3);
            q.Enqueue(fb4);

            while(q.Any()){
                footballer temp = q.Peek();
                
                Console.WriteLine(temp.Name);
                q.Dequeue();
            }
        }

        
    }
    
}
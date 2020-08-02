using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Net_Practice
{
    class Batsman
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ID { get; set; }
    }
    
    class Bowler
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ID { get; set; }
    }
    
    public class demo{
        static void Main()
        {
            // Create a list of dancers
            List<Batsman> Batsmans = new List<Batsman> {
                new Batsman { Fname = "virat", Lname = "kohli", ID = 17 },
                 new Batsman { Fname = "KL", Lname = "Rahul", ID = 22 },
                 new Batsman { Fname = "Hardik", Lname = "Pandya", ID = 11 },
                 new Batsman { Fname = "Shivam", Lname = "Dube", ID = 7 } };
        
            // Create a list of Singers
            List<Bowler> Bowlers = new List<Bowler> {
                new Bowler { Fname = "Jasprit", Lname = "Bumrah", ID = 20 },
                new Bowler { Fname = "Hardik", Lname = "Pandya", ID = 11 },
                new Bowler { Fname = "Shivam", Lname = "Dube", ID = 7 } };
        
            // Join the two data sources based on a composite key consisting of first and last name,
            // to determine which Dancer is also a Singer.
            IEnumerable<string> query = from Batsman in Batsmans
                                        join Bowler in Bowlers
                                        on new { Batsman.Fname, Batsman.Lname }
                                        equals new {Bowler.Fname, Bowler.Lname }
                                        select Batsman.Fname + " " + Batsman.Lname;
        
            foreach (string name in query)
                Console.WriteLine(name);
        }
        
    }
    
}
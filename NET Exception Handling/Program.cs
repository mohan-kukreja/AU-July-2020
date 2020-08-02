using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Net_Practice
{
    
    public class demo{
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"/Users/mohan/Desktop/sample.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found!" + ex);
               
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found" + ex);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception caught" + ex);
              
            }
            finally
            {
                Console.WriteLine("Closing application" );
            }
            Console.ReadLine();
        }

        
    }
    
}
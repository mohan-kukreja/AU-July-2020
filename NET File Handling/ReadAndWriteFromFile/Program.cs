using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string dir = @"/Users/mohan/Desktop/FileIO";
        // If directory does not exist, create it
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        string fileName = @"/Users/mohan/Desktop/FileIO/test.txt";

        try
        {


            // Create a new file     
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                sw.WriteLine("Author: Mohan Kukreka");
                sw.WriteLine("Add one more line ");
                sw.WriteLine("Add one more line ");
                sw.WriteLine("Done! Thank You");
            }

            // Write file contents on console.     
            var numberOfCharacters = File.ReadAllLines(@"/Users/mohan/Desktop/FileIO/test.txt").Sum(s => s.Length);
            Console.WriteLine(numberOfCharacters);

            try
            {

                using (StreamReader sr = new StreamReader(@"/Users/mohan/Desktop/FileIO/test.txt"))
                {
                    Stack<string> myStack = new Stack<string>();
                    int count = 0;
                    using (StreamWriter sw1 = File.CreateText(@"/Users/mohan/Desktop/FileIO/test1.txt"))
                    {
                        string line;
                        string line2 = "";


                        while ((line = sr.ReadLine()) != null)
                        {
                            myStack.Push(line);
                            count++;

                        }

                        while (count > 0)
                        {
                            string l = myStack.Pop();
                            sw1.WriteLine(l);
                            count--;

                        }


                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.ToString());
        }
    }







}
using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace AU_Accolite
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Boolean flag = true;
            log.Info("Program Started Executing");
            try
            {
                string content = File.ReadAllText(@"/Users/mohan/Desktop/c#.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                flag = false;
                Console.WriteLine("File not found " + ex.Message);
                log.Error(ex.StackTrace);
            }
            catch (DirectoryNotFoundException ex)
            {
                flag = false;
                Console.WriteLine("Directory not found " + ex.Message);
              
                log.Error(ex.StackTrace);
            }
            catch (IOException ex)
            {
                flag = false;
                Console.WriteLine("An IO Exception Occured " + ex.Message);
                log.Error(ex.StackTrace);
            }
           
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("An exception caught " + ex.Message);
                log.Error(ex.StackTrace);
            }
            finally
            {
                if (!flag)
                {
                    log.Warn("Unsuccessful File Read ");
                }
                else
                {
                    Console.WriteLine("Closing application now ");
                    log.Info("Program Execution Ended");
                }

            }
            Console.ReadLine();


        }
    }
}

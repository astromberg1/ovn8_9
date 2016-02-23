using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /*  Exercise 8  
  The same company as in the previous exercise gets the idea that they should be able to log interesting things as they happen.They give you the task of writing a “Logger”-class.  
  Main Task
  1. Start by creating a new Console project and call it “Exercise8”.  
  2. Create a class called “Logger”.  
  3. This class should have a Log method:  
  public void Log(string message)
   {     // Add the message to a private List<string> }  
  4.Add a public property called “LogPosts” which returns the private List with all logs.Only the get accessor should be public:  
  public List<string> LogPosts { get; private set; }  
  5. Create a default constructor(no parameters) which initializes the list:  
  public Logger() { LogPosts = new List<string>(); }  
  6. In the Main method, create a new instance of a Logger and add some posts by calling the Log method:  
  var myLogger = new Logger(); myLogger.Log("First post"); myLogger.Log("Second post"); ...  
  7. To make sure that the class is working: use the “LogPosts”-property to loop through the List and print all the values you just added to the console:  
  foreach (var item in myLogger.LogPosts) {     Console.WriteLine(item); }
  */

    //class logPosts
    //   






    class Logger
    {
        public List<string> LogPosts { get; private set; }

        public Logger()
        {
            LogPosts = new List<string>();


        }

        public void Log(string message)
        {
            LogPosts.Add(message);


        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");
            myLogger.Log("Third post");
            myLogger.Log("Last post");


            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}
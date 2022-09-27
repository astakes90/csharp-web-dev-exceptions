using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("y", "Value of Y cannot be 0.");
            }
            else
            {
                return x / y;
            }
        }



        static int CheckFileExtension(string fileName)
        {

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName", "No work submitted.");
            }
            else 
            {
                if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            try
            {
                Divide(10, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            Console.WriteLine(CheckFileExtension(students["Carl"]));
            Console.WriteLine(CheckFileExtension(students["Brad"]));
            Console.WriteLine(CheckFileExtension(students["Elizabeth"]));
            Console.WriteLine(CheckFileExtension(students["Stefanie"]));
        }
    }
}

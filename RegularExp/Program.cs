using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RegularExp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = "Sanjay", pattern2, readText, fileName;
            var Names = new List<string>();
            Names.Add("Balaji");
            Names.Add("Mukesh");
            Names.Add("Savari");
            Names.Add("Selva");
            Names.Add("Murali");
            
            foreach (var Name in Names)
            {
                Console.WriteLine(Name);
            }
            
            //path - //D:\Practice Programs C#\file handling C# - practice
            //path - //D:/Practice Programs C#/file handling C# - practice/test1.txt
            Regex rx = new Regex("[0-9]");
            //Console.WriteLine(rx.IsMatch(pattern1));
            //Console.WriteLine("enter a File name with extension to use : ");
           // fileName = Console.ReadLine();
            String fileName2 = System.IO.File.ReadAllText(@"D:/Practice Programs C#/file handling C# - practice/test1.txt");
          //  readText = File.ReadAllText(fileName);
            Console.WriteLine();
            //Console.WriteLine("File has the content of : " + readText);
            Console.WriteLine("File has the content of : " + fileName2);
            if(!rx.IsMatch(fileName2))
            {
                Console.WriteLine("Enter a valid format of the dictionary...");
            }
            else
            {
                Dictionary<int, string> StudentList = new Dictionary<int, string>();

                StudentList.Add(int.Parse(fileName2), "Programmer");
                StudentList.Add(1002, "Project Manager");
                StudentList.Add(1003, "Architect");
                StudentList.Add(1004, "Asst. Project Manager");
                StudentList.Add(1005, "Manager");

                foreach (var Emp in StudentList)
                {
                    Console.WriteLine(Emp);
                }
            }


        }
    }
}

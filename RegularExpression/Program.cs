using System;

namespace PropertiesInCS
{
    public class Prop
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Prop newStudent = null;

            newStudent = new Prop();
            newStudent.StudentName = "Savari007";
            newStudent.StudentID = 49;
            // string Sample = "Savari, Balaji, Selva@Gmail";
            Console.WriteLine(newStudent.StudentName);
            Console.WriteLine(newStudent.StudentID);

        }
    }
}

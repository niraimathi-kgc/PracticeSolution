using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID,PID,Birth,Roomno;
            string Sname, SclName,FName, Lname;
            var student = new Student()
            {
                StudentID = ID,
                StudentName = Sname,
                SchoolName = SclName;
            }


        var serializer = new XmlSerializer(typeof(Student));
            using (var writer =  new StreamWriter("patients.xml"))
            {
                Serializer.Serialize(writer, patient);
            }
        }
    }
}

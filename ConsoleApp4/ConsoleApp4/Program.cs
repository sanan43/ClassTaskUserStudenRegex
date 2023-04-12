using ConsoleApp4.Models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User students= new Student();
            students.Name = "sanan";
            students.Surname = "shahmammadov";
            students.Password= "sanan123";  
            students.PhoneNumber= "+994 519-279711";
            Console.WriteLine(students.Name);
            Console.WriteLine(students.Surname);
            Console.WriteLine(students.Password);
            Console.WriteLine(students.PhoneNumber);
        }
    }
}
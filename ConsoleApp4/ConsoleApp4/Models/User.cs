using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public abstract class User
    {
        


        private string _Password;
        private string _Name;
        private string _Surname;
        private string _PhoneNumber;

        public int id { get; set; }
        public string Name { get
            {
                return _Name;
            }
            set 
            {
                if (value.Length<3)
                {
                    Console.WriteLine("uzunqlu en azi 3 olmalidir!");
                }
                else
                {
                    _Name= value;
                }
            } }
        public string Surname { get
            {
                return _Surname;
            }
            set 
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("uzunqlu en azi 3 olmalidir!");
                }
                else
                {
                    _Surname = value;
                }
            } }
        public string PhoneNumber { get
            { 
                return _PhoneNumber;
            }
            set
            {
                string phoneRegex = @"^[+994]+\s+(50|51|70|77|55)+[1-9]{1}-[0-9]{6}$";
                if (Regex.IsMatch(value, phoneRegex))
                {
                    _PhoneNumber = value;
                    return;
                }
                else
                {
                    Console.WriteLine("The phone number is not valid");
                    
                }
            } }
        public string Password { 
            get
            {
                return _Password;
            }
            set 
            {
                if (value.Length<8)
                {
                    Console.WriteLine("Password uzunlugu en az 8 olmalidir!");
                }
                else
                {
                    _Password= value;
                }
            } }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _10
{
    public class Employ
    {
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private DateTime _dateofBirth;
        public DateTime Dateofbirth { get 
            {
                return _dateofBirth;
            } set
            {
                DateTime dateB = Dateofbirth;
                TimeSpan age = DateTime.Now - dateB;
                Console.WriteLine($"date of birth: {Dateofbirth}");
                Console.WriteLine($"Age: {age}");
            }
            }


        public Employ (string country, string gender, string contact, string name, string surname, DateTime dateofbirth)
        {
            Country = country;
            Gender = gender;
            Contact = contact;
            Name = name;
            Surname = surname;
            Dateofbirth = dateofbirth;
        }
        public void PrintInfoAge()
        {
            Console.WriteLine(Dateofbirth);
        }

    }
}

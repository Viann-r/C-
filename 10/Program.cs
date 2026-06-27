namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ emp1 = new Employ("Japan", "Female", "Phone", "Name", "emp1", new DateTime(2000, 1, 23));
            Employ emp2 = new Employ("Japan", "Female", "Email", "Name", "emp2", new DateTime(2002, 1, 20));
            Employ emp3 = new Employ("Japan", "Male", "Phone", "Name", "emp3", new DateTime(2001, 3, 5));
            Employ emp4 = new Employ("Japan", "Female", "Email", "Name", "emp4", new DateTime(2003, 8, 23));
            Employ emp5 = new Employ("Japan", "Male", "Phone", "Name", "emp5", new DateTime(2000, 7, 23));
            Employ emp6 = new Employ("Japan", "Male", "Email", "Name", "emp6", new DateTime(2000, 12, 11));
            Employ emp7 = new Employ("Japan", "Female", "Phone", "Name", "emp7", new DateTime(2000, 6, 27));
            Employ emp8 = new Employ("Japan", "Male", "Email", "Name", "emp8", new DateTime(2001, 2, 24));



            Employ[] employs = new Employ[8];
            foreach (var employ in employs)
            {
                if (employ.Country == "Japan")
                {
                    Console.WriteLine($"{employ.Surname} is living in Japan");
                }
            }


        }
    }
}

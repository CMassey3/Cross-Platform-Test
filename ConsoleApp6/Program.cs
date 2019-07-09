using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var firstName = "Camden";
            var lastName = "Massey";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var me = new string[2] { firstName, lastName };
            var personalName = string.Join(" ", me);
            Console.WriteLine(personalName);

            var text = @"Hi John
     Look into the following paths
     c:\folder1\folder2
     c:\folder3\folder4";

            Console.WriteLine(text);
        }
    }
}

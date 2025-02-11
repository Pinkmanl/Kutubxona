using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace kutubxona.Classes
{
    public class Learner
    {
        public static string? userName1 { get; set; }
        string SEPARATOR = "; ";
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }
        public int ReadBook { get; set; }
        public Learner(int id, string name, string lastname, int age, string login, string password, int readBook)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Age = age;
            Login = login;
            Password = password;
            ReadBook = readBook;
        }

        public string LearnersGetFormat()
        {
            return Id + SEPARATOR + Name + SEPARATOR + Lastname + SEPARATOR + Age + SEPARATOR + Login + SEPARATOR + Password + SEPARATOR + ReadBook;
        }
        public static void listAdd()
        {
            
            int length = Library.learners.Count;
            int addId = length + 1;
            System.Console.WriteLine("ismni kiriting");
            string addName = Console.ReadLine() ?? "";
            System.Console.WriteLine("familyanggizni kiriting");
            string addLastname = Console.ReadLine() ?? "";
            System.Console.WriteLine("sizning yoshingiz ");
            int addAge = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("login yarating");
            string addLogin = Console.ReadLine() ?? "";
            System.Console.WriteLine("parol qo'ying");
            string addPassword = Console.ReadLine() ?? "";
            int addReadBook = 0;
            Library.learners.Add(new Learner(addId, addName, addLastname, addAge, addLogin, addPassword, addReadBook));
            userName1 = addName;
        }
        public static void LearnersWrite()
        {
            StreamWriter LearnerWriter = new(Library.learnerName);

            foreach (Learner item in Library.learners)
            {
                LearnerWriter.WriteLine(item.LearnersGetFormat());
            }
            LearnerWriter.Close();
        }
       
    }
}
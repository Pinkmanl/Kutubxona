using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutubxona.Classes
{
    public class Book
    {
        string SEPARATOR = ",";
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public uint Count { get; set; }
        public uint RemainingCount { get; set; }
        public string LearnerBook { get; set; }

        public Book(uint id, string name, string genre, string author, uint count, string learnerBook)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Author = author;
            Count = count;
            RemainingCount = count;
            LearnerBook = learnerBook;
        }
        public void BookDate(string name)
        {
            if (name == Name)
            {
                Console.WriteLine($"kitob ID {Id}; kitob nomi {Name}; kitob janri {Genre}, kitob afteri {Author}; qancha kitob qolgani {RemainingCount - 1}; kimlar o'qiyotganlar {LearnerBook}");
            }
        }
        public string BookGetFormat()
        {
            return Id + SEPARATOR + Name + SEPARATOR + Genre + SEPARATOR + Author + SEPARATOR + RemainingCount + SEPARATOR + LearnerBook;
        }
        public static void BooksRead()
        {
            StreamReader reader = new StreamReader(Library.fileName);
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            reader.Close();
        }
        public static void BookWriter()
        {
            StreamWriter LearnerWriter = new(Library.fileName);

            foreach (Book item in Library.books)
            {
                LearnerWriter.WriteLine(item.BookGetFormat());
            }
            LearnerWriter.Close();
        }
        public static void GetBook(string enterBookName, string entername)
        {
            foreach (Book item in Library.books)
            {
                item.RemainingCount = item.RemainingCount - 1;
                item.LearnerBook = item.LearnerBook + "  " + entername;
            }
            foreach (Learner item in Library.learners)
            {
                item.ReadBook = item.ReadBook + 1;
            }

        }
        public static void GiveBook(string enterBookName, string entername)
        {
            foreach (Book item in Library.books)
            {
                if (item.LearnerBook.Contains(entername))
                {
                    item.RemainingCount = item.RemainingCount + 1;
                    //   string result = text.Replace(wordToRemove, "");
                    item.LearnerBook = item.LearnerBook.Replace(entername, "");
                    foreach (Learner item2 in Library.learners)
                    {
                        item2.ReadBook = item2.ReadBook - 1;
                    }
                }
            }




        }

    }
}
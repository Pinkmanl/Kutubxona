using System.ComponentModel;

namespace kutubxona.Classes
{
    public class Library
    {
        public static string learnerName = "Learners.txt";
        public static List<Learner> learners = new List<Learner>
        {
            new Learner( 1, "vali", "valiyev", 45, "vali45","Vali0045",1),
            new Learner( 2, "soli", "soliyev", 10, "soli10","soli0045",1),
            new Learner( 3, "ali",  "aliyev ", 35, "ali035","Vali0045",1),
        };
        public static List<Book> books = new List<Book>
            {
                new Book(1, "G'rbiy frotda o'zgarish yo'q", "Jangari", "REMARK", 101,"vali"),
                new Book(2, "Kichkina shaxzoda", "hikoya", "Antuan de Sent-Ekzüper", 50,"soli"),
                new Book(3, "Ikki eshik orasi", "Sotsial-realistik", "Abdulla Qodiriy", 45,"ali"),
            };

        public static string bookName = "Kutubxona.txt";
        public static void fileWrite()
        {
            StreamWriter BookWriter = new(bookName);

            foreach (Book item in books)
            {
                BookWriter.WriteLine(item.BookGetFormat());
            }
            BookWriter.Close();
        }

        public static void BookDateOut(string enterBookName)
        {
            foreach (Book item in books)
            {
                item.BookDate(enterBookName);
            }
        }
        

    }
}
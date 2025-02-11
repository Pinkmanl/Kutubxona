﻿using System;
using System.ComponentModel;
using System.Text.Json;
using System.Xml.Linq;
using kutubxona.Classes;
namespace kutubxona
{
    class Program
    {
        static void Main()
        {
            string? userName = "";
            int tekshuruv = 0;
            do
            {
                System.Console.WriteLine("1.Hisobga kirish");
                System.Console.WriteLine("2.Royxatdan o'tish");
                int buyruq = Convert.ToInt16(Console.ReadLine());

                switch (buyruq)
                {
                    case 1:
                        System.Console.WriteLine("loginni kiriting");
                        string enterLogin = Console.ReadLine() ?? "";
                        System.Console.WriteLine("parolni kirting");
                        string enterPassword = Console.ReadLine() ?? "";
                        foreach (Learner item in Library.learners)
                        {
                            if (enterLogin == item.Login && enterPassword == item.Password)
                            {
                                System.Console.WriteLine($"id: {item.Id}, ismi: {item.Name}, yoshi: {item.Age}");
                                System.Console.WriteLine($"login: {item.Login}, parol: {item.Password}, O'qiyotgan kitob nomi: {item.ReadBook}");

                                tekshuruv = tekshuruv + 1;
                                userName = item.Name;
                            }
                        }
                        break;
                    case 2:
                        Learner.listAdd();
                        System.Console.WriteLine("Ro'yxatdan o'tdinggiz");
                        tekshuruv = tekshuruv + 1;
                        userName = Learner.userName1;
                        break;

                }
            } while (tekshuruv == 0);
            int buyruq2 = 0;
            do
            {
                System.Console.WriteLine("1.kitoblar ro'yxati");
                System.Console.WriteLine("2.kitob haqida malumot");
                System.Console.WriteLine("3.kitob oilsh");
                System.Console.WriteLine("4.kitob qaytarish");
                System.Console.WriteLine("5.dasturni tugatish");
                buyruq2 = Convert.ToInt16(Console.ReadLine());
                switch (buyruq2)
                {
                    //kitoblar ro'yxati
                    case 1:
                        foreach (Book item in Library.books)
                        {
                            System.Console.WriteLine(item.Name);
                        }
                        break;
                    //tanlangan kitob haqida malumotlar
                    case 2:
                        System.Console.WriteLine("kitob nomini kiriting");
                        string enterBookName = Console.ReadLine() ?? "";
                        Library.BookDateOut(enterBookName);
                        break;
                    //kitob olish
                    case 3:
                        System.Console.WriteLine("qaysi kitobni olmoqchi siz");
                        string entername = Console.ReadLine() ?? "";

                        Book.GetBook(entername, userName ?? "");
                        break;
                    // kitob topshirish
                    case 4:
                        System.Console.WriteLine("qaysi kitobni topshirasiz");
                        string entername2 = Console.ReadLine() ?? "";

                        Book.GiveBook(entername2, userName ?? "");
                        break;
                    case 5:
                        Learner.LearnersWrite();
                        Book.BookWriter();
                        break;
                }
                Learner.LearnersWrite();

            } while (buyruq2 != 5);
        }
    }
}
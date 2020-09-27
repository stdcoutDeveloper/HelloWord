using System;

namespace HelloWorld
{
    internal class Book
    {
        private string author_;
        private int pages_;
        private string title_;
        private int wordCount_;

        public Book()
        {
        }

        public Book(string title)
        {
            title_ = title;
        }

        public Book(string title, string author)
        {
            title_ = title;
            author_ = author;
        }

        public Book(string title, string author, int pages, int wordCount)
        {
            title_ = title;
            author_ = author;
            pages_ = pages;
            wordCount_ = wordCount;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public void DoSomething()
        {
            for (var x = 0; x < 10; x++)
                Console.WriteLine(x);

            for (var x = 50; x < 60; x++)
                Console.WriteLine(x);
        }

        public string GetTitle()
        {
            return title_;
        }

        public void SetTitle(string title)
        {
            title_ = title;
        }

        public void AssignWordCountFromText(string text)
        {
            wordCount_ = text.Split(' ').Length;
        }
    }

    public static class StaticClass
    {
        public static int sharedNumber_;

        static StaticClass()
        {
            sharedNumber_ = 3;
        }

        public static double AddTwoNumbers(double firstNumb, double secondNumb)
        {
            return firstNumb + secondNumb;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_13_Abstract_Classes
{
    class MyBook : Book
    {
        private int p;

        public MyBook(string t, string a, int p) : base(t, a)
        {
            this.p = p;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}\n" +
                              $"Author: {author}\n" +
                              $"Price: {p}");
        }
    }
}

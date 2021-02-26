using System;

namespace Day_13_Abstract_Classes
{
    class Program
    {
        /*
         * https://www.hackerrank.com/challenges/30-abstract-classes/tutorial
         * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/abstract
         * https://hackerrankweb.wordpress.com/2016/11/29/day-13-abstract-classes/
         */
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}

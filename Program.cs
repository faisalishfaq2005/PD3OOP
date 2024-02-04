using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<book> bookList = new List<book>();
            book book1 = new book("Pride and predijuce","Jane Autson","1978",19.99);
            bookList.Add(book1);
            book book2 = new book("Hamlet", "Williom Shakespare", "1603", 15.50);
            bookList.Add(book2);    
            book book3 = new book("War and Peace", "Leo Tosley", "1343", 25.99);
            bookList.Add(book3);

            foreach (var ele in bookList)
            {
                Console.WriteLine(ele.title);
                Console.WriteLine(ele.author);
                Console.WriteLine(ele.publicationYear);
                Console.WriteLine(ele.price);
               



            }

            Console.WriteLine("enter title of the book");
            string title = Console.ReadLine();
            foreach(var ele in bookList)
            {
                if(ele.title==title)
                    Console.WriteLine(ele.author);
            }

            Console.WriteLine("enter title of book");
            string titles = Console.ReadLine();
            foreach (var ele in bookList)
            {
                if (ele.title == titles)
                    ele.sellCopies(10);
            }

            Console.WriteLine("enter title of book");
            string titless = Console.ReadLine();
            foreach (var ele in bookList)
            {
                if (ele.title == titless)
                    ele.addCopies(10);
            }

            Console.WriteLine(bookList.Count());
        }
    }
}

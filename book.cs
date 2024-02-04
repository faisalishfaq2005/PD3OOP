using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class book
    {
        public string title;
        public string author;
        public string publicationYear;
        public double price;
        public int stock;

        public book() { }
        public book(string title,string author,string publicationYear,double price,int stock)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.price = price;
            this.stock = stock;

        }
        public book(string title, string author, string publicationYear, double price)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.price = price;
            

        }
        public string getTitle()
        {
            string str = "title: " + title;
            return str;
        }
        public string getAuthor()
        {
            string str = "Author: " + author;
            return str;
        }
        public string getPublicationYear()
        {
            string str = "Publication Year: " + publicationYear;
            return str;
        }
        public string  priced()
        {
            string str= "Price: " +price.ToString();
            return str;
            
        }
        public void sellCopies(int noofcopies)
        {
            if(stock-noofcopies>=0) 
            {
                stock=stock-noofcopies;
                Console.WriteLine("Copies sold");
            }
            else
            {
                Console.WriteLine("Not enough copies in stock");
            }
            

        }
        public void addCopies(int noofcopies)
        {
            stock = stock + noofcopies;
           
        }
        public void bookDetails()
        {
            Console.WriteLine("Title: " + title + " Author: " + author + " Publication Year: " + publicationYear + " Price: " + price + " Stock: " + stock);
        }

    }
}

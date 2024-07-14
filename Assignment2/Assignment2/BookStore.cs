using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class BookStore
    {
        public string ISBN;
        public string BookName;
        public string BookTitle;
        public string BookAuthor;
        public int QuantityOfBooks;
        public int BookPrice;

        public BookStore(string isbn, string bookName, string bookTitle, 
            string bookAuthor, int quantityOfBooks, int bookPrice)
        {
            ISBN = isbn;
            BookName = bookName;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            QuantityOfBooks = quantityOfBooks;
            BookPrice = bookPrice;

        }
       
        public void Calculate_amount()
        {
            Console.WriteLine("Total Price of the books are " + QuantityOfBooks*BookPrice);
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Book Title: {BookTitle}");
            Console.WriteLine($"Book Author: {BookAuthor}");
            Console.WriteLine($"Quantity of Books: {QuantityOfBooks}");
            Console.WriteLine($"Book Price: {BookPrice:C}");
        }

        static void Main()
        {
            BookStore bookstore = new BookStore("12345"
                ,"Programming","Basics of Programming","someone",3,30);
            
            bookstore.Calculate_amount();
            bookstore.DisplayBookDetails();
        }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLatest
{
   public class RentInfo
    {       
        public DateTime RentDate { get; set; }
        public DateTime ReturnedDate { get; set; }

        [ForeignKey ("BookId")]
        public int BookId { get; set; }//pointer for book class

        [ForeignKey ("StudentId")]
        public int StudentId { get; set; }// pointer for student class

        public string BookAuthor { 
            get { 
                if (books != null)
                    return books.Author;
                return null;
            } }

        public Book books;
        public Student students;
        //public List<Book> rentBooks;
        public RentInfo() {
            // students.Id = StudentId;
            //books = new Book();
            //rentBooks = new List<Book>();
        }              
        public void BookOnRent(Book book, DateTime bookRentDate, DateTime bookReturnedDate)
        {
            books = book;
            RentDate = bookRentDate;
            ReturnedDate = bookReturnedDate;

            Console.WriteLine($"Book rented successfully !");
            Console.WriteLine($"Book Rented on: {RentDate.Date}");
            Console.Write($"Book returned on: {ReturnedDate.Date}\n");

            Console.WriteLine();
        }
        public void BookRentDate()
        {
        }
    }
}

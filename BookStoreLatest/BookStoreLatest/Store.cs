using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLatest
{
   public class Store
    {       
        //ManageStore
        public List<Book> availableBooks;
        public List<Book> rentedBooks;
        public List<Student> students;
        public Store()
        {
            availableBooks = new List<Book>();
            rentedBooks = new List<Book>();
            students = new List<Student>();
        }
        public void AddBook(Book book)
        {
            availableBooks.Add(book);
        }
        public void RemoveBook(Book book)
        {
            availableBooks.Remove(book);
        }
        public void BrowseBook()
        {
            Console.WriteLine($"{availableBooks.Count} books are available");
            foreach (var book in availableBooks)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }

            Console.WriteLine($"{rentedBooks.Count} books are rented");
            foreach (var book in rentedBooks)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }
        }        
        public void RentBook(Book book)
        {
            availableBooks.Remove(book);
            rentedBooks.Add(book);
        }
        public void ReturnBook(Book book)
        {
            availableBooks.Add(book);
            rentedBooks.Remove(book);
        }
        public Book SearchBookByTitle(string bookTitle)
        {
            foreach(var book in availableBooks)
            {
                if (book.Title == bookTitle)
                    return book;                
            }
            return null;
        }
        //public Student SearchStudentById(string studentId)
        //{
        //    foreach(var student in students)
        //    {
        //        if (student.Id == studentId)
        //            return student;                               
        //    }
        //    return null;
        //}
       
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLatest
{
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 1 to 1 only class name
        // var Book book;
        //1 to many we use list of class variable as a reference          
        public Student()
        {
        }
        public List<Book> books { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            books = new List<Book>();
        }
        public void RentBook(Book book)
        {          
            books.Add(book);          
        }
        public void ViewBook()
        {
            Console.WriteLine($"Viewing books for {Name} ({Id})");
            foreach (var book in books)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }
        }
        public void ReturnBook(Book book)
        {
            books.Remove(book);
        }
    }
}

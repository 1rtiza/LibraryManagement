using System;

namespace BookStoreLatest
{
    class Program
    {
        static void Main(string[] args)
        {
            RentInfo rent = new RentInfo();

            Console.WriteLine("Book Store \n");

            while (true) {

                Console.WriteLine("ADMIN DASHBOARD\n");
                Console.WriteLine("1. Add book to rent");
                Console.WriteLine("2. View rented Book");
                Console.WriteLine("3. Books that are on rent");
                Console.WriteLine("0. Exit Application");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter books to rent");
                        string enterBook = Console.ReadLine();
                        Console.WriteLine("Enter Date of rent");
                        DateTime rentBookDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Return Date of book");
                        DateTime bookReturnDate = DateTime.Parse(Console.ReadLine());
                        Book book = new Book(enterBook);
                        rent.BookOnRent(book,rentBookDate,bookReturnDate);
                       
                        break;
                    case 2:
                        rent.BookRentDate();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 0:
                        return;                        
                }           
            }
        }
    }
}


























/* 
 //  Store store = new Store();
     Console.WriteLine("Welcome to the Book Shop");
            while (true) {
                Console.WriteLine("\nADMIN DASHBOARD");
                Console.WriteLine("1. Add books to store");
                Console.WriteLine("2. Remove books from store");
                Console.WriteLine("3. View books own by a student\n");
                Console.WriteLine("STUDENT DASHBOARD");
                Console.WriteLine("4. Rent Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Browse Book\n");
                Console.WriteLine("0. Exit\n");
                Console.Write("Select option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the volume: ");
                        int volume = int.Parse(Console.ReadLine());
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        if(string.IsNullOrEmpty(title) || price == 0)
                        {
                            Console.WriteLine("Title cannot be empty and price can not be zero");
                            break;
                        }
                        if(store.SearchBookByTitle(title)!= null)
                        {
                            Console.WriteLine("A book with {0} already exist", title);
                            break;
                        }
                        Book book = new Book(title,price);
                        book.Volume = volume;
                        book.Author = author;
                        store.AddBook(book);
                        Console.WriteLine("Book has been added!");                        
                     
                        break;
                    case 2:
                        Console.Write("Enter the book title to remove a book: ");
                        string titleRemove = Console.ReadLine();
                        Book bookRemove = store.SearchBookByTitle(titleRemove);
                        if (bookRemove == null)
                        {
                            Console.WriteLine("No book with this title exist");
                            break;
                        }

                        store.RemoveBook(bookRemove);
                        Console.WriteLine("Book has been removed!");         

                        break;
                    case 3:
                        //Console.WriteLine("Enter title to view a book");
                        Console.WriteLine("3");
                        break;
                    case 4:
                        Console.WriteLine("3");
                        break;
                    case 5:
                        Console.WriteLine("4");
                        break;
                    case 6:
                        Console.WriteLine("Books Added are: ");
                        store.BrowseBook();
                        break;
                    case 0:
                        Console.WriteLine("Thank you for using the Application");
                        return;
                        
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }     



*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLatest
{
   public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }        
        public double Price { get; set; }
        public string Author { get; set; }
        public Book()
        {
        }
        public Book(string title)
        {
            Title = title;
        }
        public Book(string title, double price )
        {
            Title = title;
            Price = price;
        }
        public override string ToString() {
            return $"Title: {Title}\nPrice: {Price}\nVolume: {Volume}\nAuthor: {Author}";
        }
    }
}

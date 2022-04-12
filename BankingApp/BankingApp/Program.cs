using System;
using System.Collections.Generic;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Contact> myContacts = new List<Contact>();
            myContacts.Add(new Contact
            {
                Name = "Irtiza",
                PhoneNumber = 232323,
                Age = 27
            }) ;

            myContacts.Add(new Contact
            {
                Name = "Developer",
                PhoneNumber = 23121,
                Age = 26
            });

            myContacts.Add(new Contact
            {
                Name = "Test",
                PhoneNumber = 11323,
                Age = 33
            });

            foreach(var i in myContacts)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.PhoneNumber);
                Console.WriteLine(i.Age);
                Console.WriteLine("*************");
            }
            
            myContacts.Insert(0, new Contact()
            {
                Name = "Ali",
                PhoneNumber = 41323,
                Age = 36
                
            });

            Console.WriteLine("!!!!!!");
            foreach (var i in myContacts)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.PhoneNumber);
                Console.WriteLine(i.Age);
                Console.WriteLine("###############");
                
            }
            
        }
    }
}

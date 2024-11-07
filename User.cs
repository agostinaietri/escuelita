using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class User
    {
        private int id { get; set; }
        private string name { get; set; }
        private List<Book> borrowedBooks { get; set; }

        public User(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.borrowedBooks = new List<Book>();
        }

        public User()
        {
            this.id = 0;
            this.name = "";
            this.borrowedBooks = new List<Book>();
        }

        public void Add(Book book) 
        {
            this.borrowedBooks.Add(book);
            book.setEstado(true);
            Console.WriteLine("Libro añadido con éxito.");
        }

        public void RemoveBook(Book book)
        {
            foreach(Book b in this.borrowedBooks)
            {
                if(b.getIsbn == book.getIsbn)
                {
                    this.borrowedBooks.Remove(b);
                    b.setEstado(true);
                    Console.WriteLine("Libro eliminado con éxito");
                    break;
                }
            }
            Console.WriteLine("Libro no encontrado.");
        }

        public int getId()
        {
            return this.id;
        }

        public List<Book> getBorrowedList()
        {
            return borrowedBooks;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Proyecto1
{
    public class Library
    {
        private List<Book> books { get; set; }
        private List<User> users { get; set; }

        public List<Book> getBooks()
        {
            return books;
        }

        public Library()
        {
            this.books = new List<Book>();
            this.users = new List<User>();

        }

        public void RegisterBook()
        {
            Console.Write("Ingrese el autor del libro: ");
            string bookAuthor = Console.ReadLine();

            Console.Write("Ingrese el título del libro: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Ingrese el ISBN del libro: ");
            string bookIsbn = Console.ReadLine();

            Book newBook = new Book(bookAuthor, bookTitle, bookIsbn);
            books.Add(newBook);
            Console.WriteLine("Libro creado con éxito");

        }

        public void RegisterUser()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese el ID del usuario: ");
            string idAux = Console.ReadLine();
            int id = int.Parse(idAux);

            User newUser = new User(id, name);
            users.Add(newUser);
            Console.WriteLine("Usuario registrado con éxito");
        }

        public void BorrowBook()
        {
            Console.Write("Ingrese el ISBN del libro a prestar: ");
            string isbnAux = Console.ReadLine();

            Console.Write("Ingrese el ID del usuario: ");
            string idAux = Console.ReadLine();
            int userId = int.Parse(idAux);


            Book foundBook = new Book();
            foundBook = FindBookByIsbn(isbnAux, books);

            User foundUser = new User();
            foundUser = FindUserById(userId, users);

            foundUser.Add(foundBook);

            Console.WriteLine("Libro prestado con éxito.");
        }

        public User? FindUserById(int id, List<User> usersAux)
        {
            User userAux = new User();
            foreach (User u in usersAux)
            {
                if (id == u.getId())
                {
                    userAux = u;
                }
            }

            if (userAux.getId() == 0)
            {
                //c
                return null;
            }
            return userAux;
        }

        public Book? FindBookByIsbn(string isbn, List<Book> auxBooks)
        {
            Book bookAux = new Book();
            foreach (Book b in auxBooks)
            {
                if (isbn == b.getIsbn())
                {
                    bookAux = b;
                }
            }

            if (bookAux.getIsbn() == "")
            {
                //c
                return null;
            }
            return bookAux;
        }

        public void ReturnBook()
        {
            Console.Write("Ingrese el ISBN del libro a devolver: ");
            string isbnAux = Console.ReadLine();

            Console.Write("Ingrese el ID del usuario: ");
            string idAux = Console.ReadLine();
            int userId = int.Parse(idAux);

            Book foundBook = new Book();
            foundBook = FindBookByIsbn(isbnAux, books);

            User foundUser = new User();
            foundUser = FindUserById(userId, users);

            foundBook.setEstado(false);
            foundUser.RemoveBook(foundBook);

            Console.Write("Libro devuelto con éxito.");
        }

        public void viewAllBookStatus(List<Book> booksAux)
        {
            foreach (Book book in booksAux)
            {
                Console.WriteLine("Estado de los libros:");
                Console.WriteLine("- El título es: " + book.title + ", Autor: " + book.author + ", ISBN: "
                    + book.getIsbn() + ", Disponible: " + book.getEstado());
            }

        }

        public void viewBorrowedBooks()
        {
            Console.WriteLine("Ingrese el ID del usuario para visualizar sus libros prestados: ");
            string auxId = Console.ReadLine();

            int userId = int.Parse(auxId);
            User foundUser = new User();
            foundUser = FindUserById(userId, users);

            foreach (Book book in foundUser.getBorrowedList())
            {
                Console.WriteLine("Estado de los libros:");
                Console.WriteLine("- El título es: " + book.title + ", Autor: " + book.author + ", ISBN: "
                    + book.getIsbn());
            }

        }
    }
}

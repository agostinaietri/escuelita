// See https://aka.ms/new-console-template for more information
using Proyecto1;

Console.WriteLine("Hello, World!");


//Book myBook = new Book("Yo", "Clase de OOP");

//Console.WriteLine($"El título del libro es { myBook.GetTitulo()}, y el autor es {myBook.author}");
//Console.WriteLine($"El título del libro es {0}, y el autor es {1}", myBook.Titulo, myBook.Author);
//Book otherBook = new Book();

//Console.WriteLine($"El título del libro es {otherBook.GetTitulo()}, y el autor es {otherBook.author}");

Console.WriteLine("Bienvenido a la biblioteca");
Console.WriteLine("1.Agregar libro\n2. Registrar usuario\n3. Prestar libro\n4. Devolver libro\n5. Ver estado de todos los libros\n6. Ver libros prestados de un usuario\n7. Salir");

bool breakWhile = false;
Library library = new Library();

string opcion = Console.ReadLine();
int opcionFinal = int.Parse(opcion);
while (!breakWhile)
{
    if(opcionFinal >= 1 && opcionFinal <=6)
    {
        switch (opcionFinal)
        {
            case 1:
                library.RegisterBook();
                break;
            case 2:
                library.RegisterUser();
                break;
            case 3:
                library.BorrowBook();
                break;
            case 4:
                library.ReturnBook();
                break;
            case 5:
                library.viewAllBookStatus(library.getBooks());
                break;
            case 6:
                library.viewBorrowedBooks();
                break;
            case 7:
                breakWhile = false;
                break;
        }
        opcion = Console.ReadLine();
        opcionFinal = int.Parse(opcion);
        Console.WriteLine("Seleccione una opción (presione 7 para salir): ");
    }
}
using Domain;
using Persistence;

namespace ConsoleApp
{
    internal class BooksService
    {
        private BooksRepository _repository;
        internal BooksService(BooksRepository repository)
        {
            _repository = repository;
        }

        internal void AddBook()
        {
            Console.WriteLine("Podaj tytuł");
            var title = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            var author = Console.ReadLine();
            Console.WriteLine("Podaj datę publikacji");
            var publicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj numer ISBN");
            var isbn = Console.ReadLine();
            Console.WriteLine("Podaj dostepność");
            var productsAvailable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cenę");
            var price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Uzupełniono pozycję. Dziękuję!");

            Book book = new Book(title, author, publicationYear, isbn, productsAvailable, price);
            _repository.Insert(book);
        }

        internal void RemoveBook()
        {
            Console.WriteLine("Podaj tytuł");
            var title = Console.ReadLine();
            Console.WriteLine("usun");
        }

        internal void ListBooks()
        {
            Console.WriteLine("Tutaj pojawi się lista książek");
            var title = Console.ReadLine();

        }

        internal void ChangeState()
        {
            Console.WriteLine("Podaj tytuł");
            var title = Console.ReadLine();
            Console.WriteLine("Dostępne sztuki");
            var available = Convert.ToInt32(Console.ReadLine());
        }
    }
}

using ConsoleApp;
using Domain;
using Persistence;


Book book = new Book();
BooksRepository repository = new BooksRepository();
BooksService booksService = new BooksService(repository);
OrdersRepository ordersRepository = new OrdersRepository();
OrderService orderService = new OrderService(ordersRepository);

Console.WriteLine(book.Title);
Console.WriteLine(book.Author);

Console.WriteLine("Podaj login");
var login = Console.ReadLine();

Console.WriteLine("Podaj hasło");
var password = Console.ReadLine();

if (login == "Admin" && password == "password")
{
    Console.WriteLine("Access Granted");

    var text = "";
    while (!text.Equals("wyjdz"))
    {
        Console.WriteLine("Witaj w menu głownym, wpisz jedną z komend");
        Console.WriteLine("dodaj");
        Console.WriteLine("usun");
        Console.WriteLine("wypisz");
        Console.WriteLine("zmien");
        Console.WriteLine("dodaj zamowienie");
        Console.WriteLine("lista zamowien");
        Console.WriteLine("wyjdz");
        text = Console.ReadLine();
        switch (text)
        {
            case "dodaj":
                booksService.AddBook();
                break;
            case "usun":
                Console.WriteLine("próba usuniecia książki");
                break;
            case "wypisz":
                Console.WriteLine("próba wypisania wszystkich książek");
                break;
            case "zmien":
                Console.WriteLine("próba zmiany stanu magazynowego książek");
                break;
            case "dodaj zamowienie":
                orderService.PlaceOrder();
                break;
            case "lista zamowien":
                orderService.ListAll();
                break;
            case "wyjdz":
                Console.WriteLine("koniec");
                break;
            default:
                Console.WriteLine("podana komenda nie jest wspierana");
                break;
        }
        Console.WriteLine("Press AnyKey");
        Console.ReadKey();
        Console.Clear();
    }
}
else
{
    Console.WriteLine("Access Denied");
}

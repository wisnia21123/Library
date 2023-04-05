using Persistence;
using Domain;


namespace ConsoleApp
{
    public class OrderService
    {
        private OrdersRepository _repository;
        public OrderService(OrdersRepository repository)
        {
            _repository = repository;
        }
        public void PlaceOrder()
        {
            Order order = new Order();
            var str = "";
            while (!str.Equals("end"))
            {
                Console.WriteLine("add-dodaj pozycje do zamowienia");
                Console.WriteLine("end-zamknij zamowienie");
                str = Console.ReadLine();
                switch (str)
                {
                    case "add":
                        Console.WriteLine("Podaj identyfikator książki");
                        var id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj ilość zamawianych książek");
                        var count = Convert.ToInt32(Console.ReadLine());
                        BookOrdered bookOrdered = new BookOrdered(id, count);
                        order.BooksOrderedList.Add(bookOrdered);
                        break;



                    case "end":
                        _repository.Insert(order);
                        break;
                    default:
                        break;
                }
            }

        }

        public void ListAll()
        {
            foreach (var item in _repository.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}

using Domain;

namespace Persistence
{
    public class OrdersRepository : BaseRepository<Order>
    {
        private List<Order> database = new List<Order>();

        public void Insert(Order order)
        {
            database.Add(order);
        }

        public List<Order> GetAll() 
        {
            return database;
        }
    }
}

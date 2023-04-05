using Domain;

namespace Persistence
{
    public class BaseRepository<T> where T : IModel
    {
        protected List<T> Database = new List<T>();
        protected int Counter;

        public void Insert(T element) 
        {
            element.Id = Counter++;
            Database.Add(element);
        }
        public void Remove(T element) 
        {
            Database.Remove(element);
        }

        public void RemoveById(int id) 
        {
            var elementToDelete = Database.First(x => x.Id == id);
            Database.Remove(elementToDelete);
        }

        public List<T> GetAll()
        { 
            return Database; 
        }

        public T GetById(int id)
        {
            return Database.First(x => x.Id == id);
        }
    }
}

    

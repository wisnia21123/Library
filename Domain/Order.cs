namespace Domain
{
    public class Order : BaseModel
    {
        public DateTime Date { get; }
        public List<BookOrdered> BooksOrderedList { get; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }

        public override string ToString()
        {
            string text = $"Order: {Date} \n";
            foreach (var item in BooksOrderedList)
            {
                text += $"Book: {item.BookId} Count: {item.NumerOrdered} \n";
            }

            return text;
        }
    }
}

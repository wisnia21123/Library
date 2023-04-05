namespace Domain
{
    public class BookOrdered
    {
        public int BookId { get; }
        public int NumerOrdered { get; }

        public BookOrdered(int bookId, int numerOrdered)
        {
            BookId = bookId;
            NumerOrdered = numerOrdered;
        }
    }
}
namespace Domain
{
    public class Book : BaseModel
    {
        public string Title { get; }
        public string Author { get; }
        public int PublicationYear { get; }
        public string ISBN { get; }
        public int ProductsAvailable { get; private set; }
        public decimal Price { get; }

        public Book() { }

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public void ChangeProductsAvailableNumber(int change)
        {
            ProductsAvailable = change;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
}
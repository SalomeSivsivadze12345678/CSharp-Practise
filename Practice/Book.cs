namespace Practice
{
    public class Book
    {
        public string Title { get; private set; }
        public readonly int BookId;
        public static int TotalBooks { get; private set; }
        public Category BookCategory { get; private set; }

        public Book(int bookId, string title, Category bookCategory)
        {
            if (bookId <= 0)
                throw new ArgumentOutOfRangeException(nameof(bookId));

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty");

            if (!Enum.IsDefined(typeof(Category), bookCategory))
                throw new ArgumentException("Invalid category");

            BookId = bookId;
            Title = title;
            BookCategory = bookCategory;

            TotalBooks++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}, book Id {BookId}, book category: {BookCategory}");
        }

    }

    public enum Category
    {
        Fiction,
        Science,
        History
    }
}
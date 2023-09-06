//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }

//    public override string ToString()
//    {
//        return $"{Title} by {Author}";
//    }
//}

//public class BookList
//{
//    private List<Book> books;

//    public BookList()
//    {
//        books = new List<Book>();
//    }

//    public void AddBook(Book book)
//    {
//        books.Add(book);
//    }

//    public void RemoveBook(Book book)
//    {
//        books.Remove(book);
//    }

//    public bool ContainsBook(Book book)
//    {
//        return books.Contains(book);
//    }

//    public Book this[int index]
//    {
//        get
//        {
//            if (index >= 0 && index < books.Count)
//            {
//                return books[index];
//            }
//            else
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//        }
//    }

//    public int Count
//    {
//        get { return books.Count; }
//    }
//}
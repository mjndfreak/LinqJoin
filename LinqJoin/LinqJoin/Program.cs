using LinqJoin;

List<Author> authors = new List<Author>
{
    new Author
    {
        AuthorId = 1, Name = "J.K. Rowling"
    },
    new Author
    {
        AuthorId = 2, Name = "George R.R. Martin"
    },
    new Author
    {
        AuthorId = 3, Name = "J.R.R. Tolkien"
    }
};
List<Book> books = new List<Book>
{
    new Book
    {
        BookId = 1, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 1
    },
    new Book
    {
        BookId = 2, Title = "A Game of Thrones", AuthorId = 2
    },
    new Book
    {
        BookId = 3, Title = "The Lord of the Rings", AuthorId = 3
    },
    new Book
    {
        BookId = 4, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 1
    }
};

var joined = from book in books
    join author in authors on book.AuthorId equals author.AuthorId
    select new
    {
        BookTitle = book.Title,
        AuthorName = author.Name
    };
    
    
foreach (var book in joined)
{
    Console.WriteLine("Book: " + book.BookTitle + "Author: " + book.AuthorName);
}

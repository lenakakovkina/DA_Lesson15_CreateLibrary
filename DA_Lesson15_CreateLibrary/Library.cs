
using System.Reflection.PortableExecutable;
using static System.Reflection.Metadata.BlobBuilder;

class Library
{
    public List <Book> books = new List <Book> ();
    public List<Reader> readers = new List<Reader>();
    public Library(List<Book> books, List<Reader> readers)
    {
        this.books = books;
        this.readers = readers;
    }

    // Method to show all books in the library
    public void ShowAvailableBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books are available in the library.");
        }
        else
        {
            Console.WriteLine("Available books in the library:");
            foreach (Book book in books)
            {
                Console.WriteLine($"- {book}");
            }
        }
    }

    // Method to show all readers in the library
    public void ShowAvailableReaders()
    {
        if (readers.Count == 0)
        {
            Console.WriteLine("No readers are available in the library.");
        }
        else
        {
            Console.WriteLine("Available readers in the library:");
            foreach (Reader reader in readers)
            {
                Console.WriteLine($"- {reader}");
            }
        }
    }

    // Method to lend a book
    public Book LendBook(string bookName, Reader reader)
    {
       Book bookToLend = books.Find(b => b.name == bookName);

        if (bookToLend != null)
        {
            books.Remove(bookToLend);
            reader.AssignBook(bookToLend);
            Console.WriteLine($"{bookToLend} has been borrowed from the library.");
            return bookToLend;
        }
        else
        {
            Console.WriteLine($"The book \"{bookName}\" is not available.");
            return null;
        }

    }
}


using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

class Reader
{
    public string name { get; private set; }
    public int id { get; private set; }

    public List<Book> assignedBooks = new List<Book>();

    public Reader(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public override string ToString()
    {
        return $"{name}";
    }

    // Method to add a book to the reader
    public void AssignBook(Book book)
    {
       
        assignedBooks.Add(book);
        Console.WriteLine($"{name} borrowed \"{book.name}\"");
    }

    // Method to remove a book from the reader
    public void RemoveBook(Book book)
    {

        assignedBooks.Remove(book);
        Console.WriteLine($"{name} return \"{book.name}\" to the library");
    }

    // Show the reader's borrowed books
    public void ShowBorrowedBooks()
    {
        if (assignedBooks.Count == 0)
        {
            Console.WriteLine($"{name} has no borrowed books.");
        }
        else
        {
            Console.WriteLine($"{name} borrowed books:");
            foreach (Book book in assignedBooks)
            {
                Console.WriteLine($"- {book}");
            }
        }
    }

}

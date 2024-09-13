class Program
{
    static void Main()
    {
        // Create some books and readers
        Book book1 = new Book("Call Me By Your Name", 2007, "Andre Aciman");
        Book book2 = new Book("Letters to Milena", 1952, "Franz Kafka");
        Book book3 = new Book("The Other Wind", 1949, "Ursula K. Le Guin");

        Reader reader1 = new Reader("Olena Artemchuk", 1);
        Reader reader2 = new Reader("Anna Petrova", 2);
        Reader reader3 = new Reader("Marta Petrova", 3);

        // Create a library 
        Library library = new Library(new List<Book> { book1, book2, book3 }, new List<Reader> { reader1, reader2, reader3});

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nLibrary System Menu:");
            Console.WriteLine("1. Show available books");
            Console.WriteLine("2. Show available readers");
            Console.WriteLine("3. Borrow a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. Show reader's borrowed books");
            Console.WriteLine("6. Exit");
            Console.Write("\nChoose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    library.ShowAvailableBooks();
                    break;
                case "2":
                    library.ShowAvailableReaders();
                    break;
                case "3":
                    Console.Write("Enter the reader's name: ");
                    string readerName = Console.ReadLine();
                    Reader borrower = library.readers.Find(r => r.name == readerName);
                    if (borrower != null)
                    {
                        Console.Write("Enter the name of the book to borrow: ");
                        string bookToBorrow = Console.ReadLine();
                        library.LendBook(bookToBorrow, borrower);
                    }
                    else
                    {
                        Console.WriteLine("Reader not found.");
                    }
                    break;
                case "4":
                    Console.Write("Enter the reader's name: ");
                    readerName = Console.ReadLine();
                    Reader returner = library.readers.Find(r => r.name == readerName);
                    if (returner != null)
                    {
                        Console.Write("Enter the name of the book to return: ");
                        string bookToReturn = Console.ReadLine();
                        library.AddBook(bookToReturn, returner);
                    }
                    else
                    {
                        Console.WriteLine("Reader not found.");
                    }
                    break;
                case "5":
                    Console.Write("Enter the reader's name: ");
                    readerName = Console.ReadLine();
                    Reader reader = library.readers.Find(r => r.name == readerName);
                    if (reader != null)
                    {
                        reader.ShowBorrowedBooks();
                    }
                    else
                    {
                        Console.WriteLine("Reader not found.");
                    }
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
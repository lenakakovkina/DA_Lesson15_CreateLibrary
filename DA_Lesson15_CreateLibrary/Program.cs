
Book book1 = new Book("ivan", 1560,"Petro QWE");
Book book2 = new Book("Book name2", 1949, "George Nyt");
Reader reader1 = new Reader("Olena", 1);

// Create a library 
Library library = new Library(new List<Book> {book1, book2}, new List<Reader> {reader1});

// Show available books in the library
library.ShowAvailableBooks();

// Reader borrows a book from the library
library.LendBook("ivan", reader1);

// Show available readers in the library
library.ShowAvailableReaders();

// Show borrowed books by readers
reader1.ShowBorrowedBooks();

// Show available books in the library
library.ShowAvailableBooks();
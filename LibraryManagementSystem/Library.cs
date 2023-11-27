namespace LibraryManagementSystem
{
    public class Library
    {
        public string Name { get; set; }
        public Book[] Books { get; set; }
        private int BookCount { get; set; }
        public Library(string name) 
        {
            Name = name;
            Books = new Book[1000];
            BookCount = 0;
        }
        public void AddBook(Book book)
        {
            if (BookCount < 1000)
            {
                Books[BookCount] = book;
                BookCount++;
                Console.WriteLine($"{book.Title} has been added succesfully.\n");
            }
            else
                Console.WriteLine("The book can't be added, because the library is full.\n");
        }
        public void RemoveBook(string isbn)
        {
            if (BookCount > 0)
            {
                for (int i = 0; i < BookCount; i++) 
                {
                    if (Books[i].ISBN == isbn)
                    {
                        Books[i] = null;
                    }
                }
            }
            else
                Console.WriteLine("The book can't be removed, because library is empty.\n");
        }
        public void DisplayBooks()
        {
            Console.WriteLine("__________________________________Library__________________________________");
            for (int i = 0; i < BookCount; i++)
            {
                
                    Console.WriteLine(Books[i].DisplayBookInfo());
                
            }
            Console.WriteLine("___________________________________________________________________________");
        }
    }
}

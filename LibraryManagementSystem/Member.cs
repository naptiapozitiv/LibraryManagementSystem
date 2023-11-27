
namespace LibraryManagementSystem
{
    public class Member
    {
        public string Name { get; set; }
        Book[] CheckedOutBooks { get; set; }
        private int MemberBooksCounter { get; set; }
        public Member(string name) 
        {
            Name = name;
            CheckedOutBooks = new Book[20];
            MemberBooksCounter = 0;
            
        }
        public void CheckOutBook(Book book)
        {
            if (MemberBooksCounter < 20)
            {
                CheckedOutBooks[MemberBooksCounter] = book;
                MemberBooksCounter++;
                Console.WriteLine("Book aded to members book list\n");

            }
            else
                Console.WriteLine("Error, can not add book to members list.\n");
        }
        public void ReturnBook(string isbn)
        {
            for (int i = 0; i < MemberBooksCounter; i++)
            {
                if (CheckedOutBooks[i].ISBN == isbn)
                    CheckedOutBooks[i] = null;
                else
                    Console.WriteLine("Error, can not remove book from member list");
            }
        }
        public void DisplayCheckedOutBooks()
        {
            Console.WriteLine("__________________________________Library__________________________________");
            for (int i = 0; i < MemberBooksCounter; i++)
            {

                Console.WriteLine(CheckedOutBooks[i].DisplayBookInfo());

            }
            Console.WriteLine("___________________________________________________________________________");
        }

    }
}

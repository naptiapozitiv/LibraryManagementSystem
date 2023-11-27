using LibraryManagementSystem;

Book qwerty = new Book("qwerty", "qwer", "qwertyu213");
Book zxcv = new Book("zxxv","zxcvv","1122334455");
Book tyuiop = new Book("tyuiop","rtyuiol","zxcvbnm123");
Library library = new Library("Central");
library.AddBook(qwerty);
library.AddBook(zxcv);
library.AddBook(tyuiop);
library.DisplayBooks();
Member somebody = new Member("Somabody S.M.");
Member somebody1 = new Member("WhoAreYou F.M.");
somebody.CheckOutBook(zxcv);
somebody.CheckOutBook(tyuiop);
somebody.CheckOutBook(qwerty);
somebody1.CheckOutBook(tyuiop);
somebody1.CheckOutBook(zxcv);
somebody1.CheckOutBook(qwerty);
somebody.ReturnBook("qwertyu213");
somebody1.ReturnBook("1122334455");
somebody.DisplayCheckedOutBooks();
somebody1.DisplayCheckedOutBooks();


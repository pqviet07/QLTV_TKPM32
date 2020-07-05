using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    enum AccountStatus
    {
        Active,
        Closed,
        Canceled,
        Blacklisted
    }
    enum BookType
    {
        Textbook,
        Autobiography,
        Thriller,
        Dictionary,
        Comic,
        Poem,
        Novel,
        Science,
        Psychology,
        ExerciseBook,
        Horror,
        ReferenceBook,
        Encyclopedia,
        Magazine,
        Programming,
        Mathematic
    }
    enum BookFormat
    {
        Ebook,
        Hardcover,
        Paperback,
        Audiobook
    }
    enum BookStatus
    {
        Available,
        Reserved,
        Loaned,
        Lost
    }
    enum ReturningStatus
    {
        Normal,
        Lost,
        Torned
    }
    enum MemberType
    {
        OneYear,
        TwoYear,
        Forever
    }
    class Fine
    {
       public decimal fineWhenLateReturningBook { get; set; }
       public decimal numsOfTimesWillMultiplyWithBookPricing_WhenBookLost { get; set; }
       public decimal numsOfTimesWillMultiplyWithBookPricing_WhenBookTorned { get; set; }
       public decimal AmountPaidForRemakeLibCard { get; set; }
    }
    interface ISearch
    {
        List<Book> searchByAuthor(string authorName);
        List<Book> searchByBookName(string bookName);
        List<Book> searchByBookType(BookType bookType);
        List<Book> searchByISBN(string ISBN);
        List<Book> searchByDateAddToLibrary(DateTime datetime);
        List<Book> searchByReferenceOnlyBook(bool isRefOnly);
        List<Book> searchByBookFormat(BookFormat bookFormat);

    }
    class Catalog : ISearch
    {
        public Dictionary<string, List<Book>> booksSearchedByBookType { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByAuthor { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByBookName { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByISBN { get; set; }
        public Dictionary<DateTime, List<Book>> booksSearchedByDateAddToLibrary { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByBookFormat { get; set; }
        public Dictionary<string, List<Book>> booksSearchedByReferenceOnlyBook { get; set; }

        public List<Book> searchByAuthor(string authorName)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByBookFormat(BookFormat bookFormat)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByBookName(string bookName)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByBookType(BookType bookType)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByDateAddToLibrary(DateTime datetime)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByISBN(string ISBN)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByReferenceOnlyBook(bool isRefOnly)
        {
            throw new NotImplementedException();
        }
    }

    class Author
    {
        public string AuthorID { get; set; }
        public string Name { get; set; }
    }
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

    }
    class PersonalInfo
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationNumber { get; set; }
        public Address Addr { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    class LibraryCard
    {
        public string LibCardNumber { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public bool Active { get; set; }
        public bool isActive()
        {
            return Active;
        }
    }
    abstract class Account
    {
        public string Username { get; set; }
        public string Password { get; private set; }
        public AccountStatus Status { get; set; }
        public string UserType { get; set; }
        public PersonalInfo personalInfo { get; set; }
        public LibraryCard libraryCard { get; set; }
        public List<Notification> listNotifications { get; set; }
        public bool changePassword() { return true; }
        public Account(LibrarySystem libSystem)
        {
            libSystem.attach(this);
        }
        public Account() { }
        public void update(Notification notification)
        {
            listNotifications.Add(notification);
        }
    }
    class Admin : Account
    {
        public bool addEmployee(Employee employee) { return true; }
        public bool removeEmployee(string username) { return true; }
    }
    abstract class Employee : Account
    {

    }

    class Librarian : Employee
    {
        public bool createBookLending() { return true; }
        public bool createBookReturning() { return true; }
        public bool addMember(string username, MemberType memType) { return true; }
        public bool renewLibraryCard(string username, MemberType memType) { return true; }
        public bool blockMember(string libCardID) { return true; }
        public bool unblockMember(string libCardID) { return true; }
    }
    class Stockkeeper : Employee
    {
        public bool addBookItem(BookItem book) { return true; }
        public bool updateBookItem(BookItem book) { return true; }
        public bool removeBookItem(string barcode) { return true; }
    }

    class Member : Account
    {
        public decimal AmountPaid { get; set; }
        public MemberType memberType { get; set; }
    }

    class Rack
    {
        public int number { get; set; }
        public char block { get; set; }
    }

    abstract class Book
    {
        string ISBN { get; set; }
        string bookName { get; set; }
        public List<Author> Authors { get; set; }
        BookType bookType { get; set; }
        string Publisher { get; set; }
        string Language { get; set; }
        int numsOfPages { get; set; }

    }

    class BookItem : Book
    {
        public string Barcode { get; set; }
        public bool isReferenceOnly { get; set; }
        public bool isBorrowed { get; set; }
        public BookFormat Format { get; set; }
        public BookStatus Status { get; set; }
        public decimal Price { get; set; }
        public DateTime dateOfPurchase { get; set; }
        public bool checkout()
        {
            return true;
        }
    }

    class BookLending
    {
        public string ID_Lending { get; set; }
        public string LibCardNumber { get; set; }
        public DateTime CreationDate { get; set; }
    }

    class BookLendingDetails
    {
        public string ID_Lending { get; set; }
        public string Barcode { get; set; }
        public DateTime DueDate { get; set; }
    }

    class BookReturning
    {
        public string ID_Lending { get; set; }
        public string Barcode { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Duration { get; set; }
        public decimal Fine { get; set; }
        public ReturningStatus Status { get; set; }
        public string Note { get; set; }
    }

    class LibrarySystem
    {
        public List<Account> listAccounts { get; set; }
        public void attach(Account account)
        {
            listAccounts.Add(account);
        }
        public void notifyAllAccount()
        {

        }
        public void notifyFine()
        {

        }
        public void notifyDueDateLibCard()
        {

        }
        public void notifyDueDateReturnBook()
        {

        }
    }

    class Notification
    {
        public string notificationID { get; set; }
        public string content { get; set; }
    }
}




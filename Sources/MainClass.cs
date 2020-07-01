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
    enum BookType{
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
    enum MemberType
    {
        OneYear,
        TwoYear,
        Forever
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
        public DateTime DateOfBirth { get; set; }
        public string IdentificationNumber { get; set; }
        public Address Addr { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    class LibraryCard
    {
        public string CardNumber { get; set; }
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
        public string UserType{get; set;}
        public PersonalInfo personalInfo { get; set; }
        public LibraryCard libraryCard { get; set; }
        public bool changePassword() { return true; }
       
    }
    class Admin : Account
    {
        bool addEmployee(Employee employee) { return true; }
        bool removeEmployee(string username) { return true; }
    }
    abstract class Employee : Account
    {

    }

    class Librarian : Account
    {
        bool addMember(string username, MemberType memType) { return true; }
        bool removeMember(string username) { return true; }
        bool renewLibraryCard(string username, MemberType memType) { return true; }
        bool blockMember(string libCardID) { return true; }
        bool unblockMember(string libCardID) { return true; }
    }
    class Stockkeeper : Account
    {
        bool addBookItem(BookItem book) { return true; }
        bool updateBookItem(BookItem book) { return true; }
        bool removeBookItem(string barcode) { return true; }
    }

    class Member : Account
    {
        public decimal AmountPaid { get; set; }
        public MemberType memberType { get; set; }
    }

    class Rack
    {
        // A_MATH_12 --> Khu A kệ 12 thể loại toán
        // B_PHYS_34
        public int number { get; set; }
        public string title { get; set; }
        public char block { get; set; }
    }
    abstract class Book
    {
        string ISBN { get; set; }
        string bookName { get; set; }
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
}




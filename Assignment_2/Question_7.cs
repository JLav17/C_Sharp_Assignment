using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Question_7
    {
        // -------------------- Book Class --------------------
        class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public bool IsIssued { get; set; } = false;

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Book ID: {BookID}, Title: {Title}, Author: {Author}, Issued: {IsIssued}");
            }
        }

        // -------------------- Member Class --------------------
        class Member
        {
            public int MemberID { get; set; }
            public string Name { get; set; }

            public void DisplayMember()
            {
                Console.WriteLine($"Member ID: {MemberID}, Name: {Name}");
            }
        }

        // -------------------- Library Class --------------------
        class Library
        {
            private List<Book> books = new List<Book>();
            private List<Member> members = new List<Member>();

            // Register a new member
            public void RegisterMember(Member member)
            {
                members.Add(member);
                Console.WriteLine("Member registered successfully!");
            }

            // Add new book
            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine("Book added successfully!");
            }

            // Lend a book to a member
            public void LendBook(int bookID)
            {
                Book book = books.Find(b => b.BookID == bookID);

                if (book == null)
                {
                    Console.WriteLine("Book not found!");
                }
                else if (book.IsIssued)
                {
                    Console.WriteLine("Book is already issued!");
                }
                else
                {
                    book.IsIssued = true;
                    Console.WriteLine("Book issued successfully!");
                }
            }

            // Show all available books
            public void ShowAvailableBooks()
            {
                Console.WriteLine("\nAvailable Books:");
                foreach (Book b in books)
                {
                    if (!b.IsIssued)
                        b.DisplayInfo();
                }
            }
        }

        // -------------------- Main --------------------
        static void Main(string[] args)
        {
            Library lib = new Library();

            // Add Books
            lib.AddBook(new Book { BookID = 1, Title = "C# Basics", Author = "John Doe" });
            lib.AddBook(new Book { BookID = 2, Title = "Java Programming", Author = "James Gosling" });
            lib.AddBook(new Book { BookID = 3, Title = "Python Intro", Author = "Guido van Rossum" });

            // Register Members
            lib.RegisterMember(new Member { MemberID = 101, Name = "Jatin" });
            lib.RegisterMember(new Member { MemberID = 102, Name = "Riya" });

            // Lend a Book
            lib.LendBook(2);

            // Show Available Books
            lib.ShowAvailableBooks();
        }
    }
}

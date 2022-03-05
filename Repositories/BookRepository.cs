using LibApp.Interfaces;
using LibApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Data;
using Microsoft.EntityFrameworkCore;

namespace LibApp.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddBook(Book book) => _context.Books.Add(book);

        public void DeleteBook(int bookId) => _context.Books.Remove(GetBookByID(bookId));

        public Book GetBookByID(int bookId) => _context.Books.Find(bookId);

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.Include(b => b.Genre);
        }

        public void UpdateBook(Book book) => _context.Books.Update(book);

        public void Save() => _context.SaveChanges();
    }
}

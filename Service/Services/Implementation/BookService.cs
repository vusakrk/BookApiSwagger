using AutoMapper;
using Domain.DAL;
using Domain.Entities;
using Service.DTOs;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services.Implementation
{
    public class BookService:IBookService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public BookService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public BookDTO Delete(int id)
        {
            var bookDb = _context.Books.FirstOrDefault(p => p.Id == id);
            if (bookDb == null)
                return null;
            _context.Books.Remove(bookDb);
            _context.SaveChanges();
            return _mapper.Map<BookDTO>(bookDb);
        }

        public BookDTO Edit(int id, BookDTO book)
        {
            var bookDb = _context.Books.FirstOrDefault(p => p.Id == id);
            if (bookDb == null)
                return null;
            book.Id = bookDb.Id;
            _mapper.Map(book, bookDb);
            _context.SaveChanges();
            return book;
        }

        public List<BookDTO> GetAllBook()
        {
            var book = _context.Books.ToList();
            return _mapper.Map<List<BookDTO>>(book);
        }

        public BookDTO GetBookId(int id)
        {
            var book = _context.Books.FirstOrDefault(p => p.Id == id);
            return _mapper.Map<BookDTO>(book);
        }

        int IBookService.Create(BookDTO book)
        {
            var newBook = _mapper.Map<Book>(book);
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook.Id;
        }
    }
}

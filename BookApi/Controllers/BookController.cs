using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Controllers
{

    public class BookController : CommonController
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public ActionResult<List<BookDTO>> GetBooks()
        {
            return Ok(_bookService.GetAllBook());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<List<BookDTO>> GetBook(int id)
        {
            return Ok(_bookService.GetBookId(id));
        }

        [HttpPost]
        public ActionResult Create([FromBody] BookDTO book)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _bookService.Create(book);
            return Ok(book);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Edit(int id,[FromBody] BookDTO book)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(_bookService.Edit(id, book));
            
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_bookService.Delete(id));
        }
    }
}

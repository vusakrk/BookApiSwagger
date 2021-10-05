using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IBookService
    {
        List<BookDTO> GetAllBook();
        BookDTO GetBookId(int id);
        int Create(BookDTO book);
        BookDTO Edit(int id, BookDTO book);
        BookDTO Delete(int id);
    }
}

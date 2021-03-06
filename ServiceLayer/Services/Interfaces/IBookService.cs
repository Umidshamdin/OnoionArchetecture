using ServiceLayer.DTOs.Book;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBookService
    {
        Task<List<BookListDto>> GetAllAsync();
        Task CreateAsync(BookListDto book);
    }
}

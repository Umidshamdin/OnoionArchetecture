using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using ServiceLayer.DTOs.Book;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<BookListDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            var res = _mapper.Map<List<BookListDto>>(model);

            return res;
        }

        public async Task CreateAsync(BookListDto book)
        {
            var books = _mapper.Map<Book>(book);
            await _repository.CreateAsync(books);

        }
    }
}

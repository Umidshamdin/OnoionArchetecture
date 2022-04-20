using Domain.Entities;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository: Repository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context):base(context)
        {

        }
    }
}

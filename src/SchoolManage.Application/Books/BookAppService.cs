using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using SchoolManage.Books.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManage.Books
{
    public class BookAppService :
         CrudAppService<
             Book, //The Book entity
             BookDto, //Used to show books
             Guid, //Primary key of the book entity
             PagedAndSortedResultRequestDto, //Used for paging/sorting
             CreateUpdateBookDto>,//Used to create/update a book
         IBookAppService

    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }

        public override BookDto Create(CreateUpdateBookDto input)
        {
            return base.Create(input);
        }


    }
}

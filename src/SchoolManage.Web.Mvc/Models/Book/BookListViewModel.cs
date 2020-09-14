using SchoolManage.Books.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Web.Models.Book
{
    public class BookListViewModel
    {
        public IReadOnlyList<BookDto> Books { get; set; }
    }
}

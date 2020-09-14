using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SchoolManage.Books.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManage.Books
{
    public interface IBookAppService :ICrudAppService< BookDto, Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto>
    {
      
    }
}

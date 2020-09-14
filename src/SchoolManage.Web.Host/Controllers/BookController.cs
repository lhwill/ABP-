using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManage.Books;
using SchoolManage.Books.Dto;

namespace SchoolManage.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookAppService bookAppService;
         const int MaxNum = 10;
         public BookController(IBookAppService courseAppService)
         {
            bookAppService = courseAppService;
         }


        public PagedResultDto<BookDto> GetBookList()
        {
            var book =  bookAppService.GetAll((new PagedAndSortedResultRequestDto { MaxResultCount = MaxNum })).Items;
            
           
            return (PagedResultDto<BookDto>)book;
        }
    }
}

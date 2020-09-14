using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManage.Books.Dto
{
    public class BookMapProfile : Profile
    {


        public BookMapProfile()
        {
            CreateMap<BookDto, Book>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}

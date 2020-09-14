using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManage.Books.Dto
{
   public class BookDto : EntityDto<Guid>
    {
        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}

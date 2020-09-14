using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManage.Books.Dto
{
    public class AuthorLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}

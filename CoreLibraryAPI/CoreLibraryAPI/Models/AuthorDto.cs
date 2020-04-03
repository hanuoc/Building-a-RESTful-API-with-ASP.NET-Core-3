using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibraryAPI.Models
{
    public class AuthorDto
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public string MainCategory { set; get; }
    }
}

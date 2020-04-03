using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibraryAPI.Models
{
    public class CourseDto
    {
        public Guid Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public Guid AuthorId { set; get; }
    }
}

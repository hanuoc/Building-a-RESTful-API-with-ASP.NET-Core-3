using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibraryAPI.Entities
{
    public class Author
    {
        [Key]
        public Guid Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string FirstName { set; get; }

        [Required]
        [MaxLength(50)]
        public string LastName { set; get; }

        [Required]
        public DateTimeOffset DateOfBirth { set; get; }

        [Required]
        [MaxLength(50)]
        public string MainCategory { set; get; }
        public ICollection<Course> Courses { set; get; }
            = new List<Course>();

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibraryAPI.Entities
{
    public class Course
    {
        [Key]
        public Guid Id { set; get; }

        [Required]
        [MaxLength(100)]
        public string Title { set; get; }

        [MaxLength(1500)]
        public string Description { set; get; }

        [ForeignKey("AuthorId")]
        public Author Author { set; get; }
        public Guid AuthorId { set; get; } 
    }
}

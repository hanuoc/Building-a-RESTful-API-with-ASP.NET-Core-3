using CoreLibraryAPI.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibraryAPI.Models
{
    [CourseTitleMustBeDifferentFromDescriptionAttribute(ErrorMessage = "The provided description should be defferent from the title.")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title Shouldn't have move than 100 characters")]
        public string Title { set; get; }
        [MaxLength(1500, ErrorMessage = "The Description Shouldn't have move than 1500 characters")]
        public virtual string Description { set; get; }
    }
}

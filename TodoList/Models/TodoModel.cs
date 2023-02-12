using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoModel
    {
        public int TaskId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = " The field can't be empty ")]
        [DataType(DataType.Text)]
        [StringLength(15, ErrorMessage = "Destription length can't be more than 15 characters.")]
        public string Name { get; set; }
        [Display(Name = "Destription")]
        [Required(ErrorMessage = " The field can't be empty ")]
        [StringLength(50, ErrorMessage = "Destription length can't be more than 50 characters.")]
        [DisplayName("Destription")]
        public string Destriptions { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dddd-yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }
    }
}

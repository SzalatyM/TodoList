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
        [DisplayName("Name")]
        [RegularExpression("Name length can't be more than 15 characters.")]
        [StringLength(15, ErrorMessage = "Name length can't be more than 20 characters.")]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "Destription length can't be more than 50 characters.")]
        [DisplayName("Destription")]
        public string Destriptions { get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd-yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }
    }
}

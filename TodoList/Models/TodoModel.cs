using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoModel
    {
        public int TaskId { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Destription")]
        public string Destriptions { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }


    }
}

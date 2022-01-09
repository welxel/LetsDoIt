using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Todo : RecordBase
    {
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }

        [MinLength(3)]
        [MaxLength(500)]
        public string Description { get; set; }

        public string Url { get; set; }

        public string Color { get; set; }

        public int IDUser { get; set; }
        public User User { get; set; } 
        public List<TodoEvent> TodoEvents { get; set; }

    }
}

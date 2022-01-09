using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace Entities.Entities
{
    public class Contact:RecordBase
    {
        public string Title { get; set; }
        [Column(TypeName = "Text")]
        public string Message { get; set; }

        public int IDUser { get; set; }
        public User User { get; set; }
    }
}

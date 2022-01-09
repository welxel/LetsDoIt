using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class User : RecordBase
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Password { get; set; }

        public bool Active { get; set; }

        public int UserDetailId { get; set; }


        public int IDCity { get; set; }
        public String Role { get; set; }
        public int IDTown { get; set; }
        public string ChatRoomID { get; set; }
        public City City { get; set; }
        public Town Town { get; set; }

        public UserDetails UserDetail { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<UserFriends> UserFriends { get; set; }
        public List<Todo> Todo { get; set; }
        public List<TodoEvent> TodoEvent { get; set; }
    }
}

using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Models
{
    public class UserRegisterModel:RecordBase
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MinLength(7)]
        [MaxLength(40)]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }
        public String Role { get; set; }
        public bool Active { get; set; } = true;
        public string Adress { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public string ChatRoomID { get; set; }
        public string Description { get; set; }
        public string Jop { get; set; }
        public List<TodoModel> Todos { get; set; }


        /// <summary>
        /// For Password Updated properties 
        /// </summary>
        /// 
        [MinLength(3)]
        [MaxLength(20)]
        public string OldPassword { get; set; }

        public string InstagramAdress { get; set; }
        public string TwitterAdress { get; set; }
        public string BlogAdress { get; set; }
        public string YoutubeAdress { get; set; }

        /// <summary>
        /// For Password Updated properties 
        /// </summary>
        /// 
        [MinLength(3)]
        [MaxLength(20)]
        public string NewPassword { get; set; }

        public int IDTown { get; set; }
        public int IDCity { get; set; }
    }
}

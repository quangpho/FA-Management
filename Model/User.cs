using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class User
    {
        [Key]
      
        [Required(ErrorMessage = "Username must be not empty!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password must be not empty!")]
        public string Password { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }


       
        public string Email { get; set; }

    }
     
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse // POCO - Plain Old C# Object
    {
        // F i e l d s // P r o p e r t i e s

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; } = "Bob"; //default value

        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string   Email { get; set; } // 

        [Required(ErrorMessage = "Phone Number Is Required")]
        [Phone]
        public string   Phone { get; set; } // 

        public bool?    WillAttend { get; set; } // true, false, null
        

        // C o n s t r u c t o r s


        // M e t h o d s

    }
}

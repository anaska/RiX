using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiX.Models
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual DateTime DateOfSignUp { get; set; }
        public virtual String Username { get; set; }
        public virtual String Email { get; set; }
        public virtual String Password { get; set; }
    }
}
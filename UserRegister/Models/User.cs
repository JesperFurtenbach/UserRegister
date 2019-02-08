using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegister.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
    }
}
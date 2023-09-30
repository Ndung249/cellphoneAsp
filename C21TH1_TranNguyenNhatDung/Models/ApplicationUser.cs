using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C21TH1_TranNguyenNhatDung.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string name { get; set; }
        public DateTime ngaySinh { get; set; }
        public string FullName { get; internal set; }
        public DateTime Birthday { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ValidationsInMvc.Models;

namespace ValidationsInMvc.Models
{
    public class UserContext:DbContext
    {
        public UserContext():base("conn")
        {

        }
        public DbSet<Register> registersTble { get; set; }
    }
}
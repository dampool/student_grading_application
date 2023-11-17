using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stud_rec.Models
{
    public class Identity:IdentityUser
    {
        //public int RegisterViewModelId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }

    }

    //public class UserLogic
    //{
    //    public Identity GetUser()
    //    {
    //        var currentUserId = User.Identity.GetUserId();
    //        var manager = new UserManager<Identity>(new UserStore<Identity>(new ApplicationDbContext()));
    //        var currentUser = manager.FindById(currentUserId);

    //        return currentUser;
    //    }
    //}

    
        
    public class ApplicationDbContext : IdentityDbContext<Identity>
     {
            public ApplicationDbContext()
                : base("Connection")
            {
            }

     }
    
}

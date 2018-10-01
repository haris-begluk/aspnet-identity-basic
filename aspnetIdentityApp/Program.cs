using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspnetIdentityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var creationResult =  userManager.Create(new IdentityUser("haris234@mail.com"), "P@ssword234");
            Console.WriteLine("Created: {0}",creationResult.Succeeded);
        }
    }
}

using Ders_3_.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ders_3_.DataAccessLayer
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() : base("AccountConnection") { }
        //public DbSet<ApplicationRoleViewModel> ApplicationRoleViewModels { get; set; }
        public virtual DbSet<ApplicationRoles> ApplicationRoles { get; set; }
        public virtual DbSet<ApplicationUserClaims> ApplicationUserClaims { get; set; }
        public virtual DbSet<ApplicationUserLogins> ApplicationUserLogins { get; set; }
        public virtual DbSet<ApplicationUsers> ApplicationUsers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CodeMonkeys.CMS.Public.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Crud_test.Data
{
    public class Crud_testContext : IdentityDbContext<User, Role, Guid>
    {
        public Crud_testContext (DbContextOptions<Crud_testContext> options)
            : base(options)
        {
        }

        public DbSet<Site> Site { get; set; } = default!;
    }
}

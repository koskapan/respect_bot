using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RespectBot.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}

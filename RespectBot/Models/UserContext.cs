using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RespectBot.Models
{
    public class UserContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<UserContext> Users { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace RespectBot.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        public long TgUserId { get; set; }
        public long Reputation { get; set; }
    }
}

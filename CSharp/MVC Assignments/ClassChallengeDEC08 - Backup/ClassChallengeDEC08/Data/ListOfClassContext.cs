using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassChallengeDEC08.Models;

namespace ClassChallengeDEC08.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext (DbContextOptions<FriendContext> options) : base(options)
        {

        }

        public DbSet<Friend> Friend { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(
            new Friend() { _friendID = 1, _friendName = "jacob", _place = "north carolina", _BirthDay = "unknown", _Gender = "staff sarnt", _NickName = "jake" },
            new Friend() { _friendID = 2, _friendName = "joeseph", _place = "wisconsin", _BirthDay = "unknown", _Gender = "male", _NickName = "joe" },
            new Friend() { _friendID = 3, _friendName = "fernando", _place = "mexico", _BirthDay = "unknown", _Gender = "male", _NickName = "leon" }
            );
        }
    }
}

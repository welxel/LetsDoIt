using AppCore.DataAccess.Configs;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DataAccess.EntityFramework.Contexts {
    public class ETradeContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<TodoEvent> TodoEvents { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserFriends> UserFriends { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            ConnectionConfig.ConnectionString = "Server=DESKTOP-09H2BRQ;Database=LetsDoIt;Trusted_Connection=True;MultipleActiveResultSets=true";
            //ConnectionConfig.ConnectionString = "Data Source =arya.veridyen.com\\MSSQLSERVER2014; Initial Catalog = LetsDoIt; Persist Security Info = True; User ID =furkan.bektas; Password =Jackal333!";
            optionsBuilder.UseSqlServer(ConnectionConfig.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>()
                .HasOne(user => user.UserDetail)
                .WithOne(userDetail => userDetail.User)
                .HasForeignKey<User>(user => user.UserDetailId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                 .HasOne(user => user.City)
                 .WithMany(city => city.User)
                 .HasForeignKey(user => user.IDCity)
                 .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                 .HasOne(user => user.Town)
                 .WithMany(town => town.User)
                 .HasForeignKey(user => user.IDTown)
                 .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Town>()
                .HasOne(town => town.City)
                .WithMany(city => city.Towns)
                .HasForeignKey(town => town.IDCity)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Todo>()
                .HasOne(todo => todo.User)
                .WithMany(user => user.Todo)
                .HasForeignKey(todo => todo.IDUser)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Contact>()
                .HasOne(contact => contact.User)
                .WithMany(user => user.Contacts)
                .HasForeignKey(contact => contact.IDUser).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<TodoEvent>()
                .HasOne<Todo>(s => s.Todo)
                .WithMany(g => g.TodoEvents)
                .HasForeignKey(s => s.IDTodo).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TodoEvent>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.TodoEvent)
                .HasForeignKey(s => s.IDUser).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserFriends>()
                .HasOne(userFriends => userFriends.User)
                .WithMany(user => user.UserFriends)
                .HasForeignKey(userFriends => userFriends.IDUser).OnDelete(DeleteBehavior.NoAction);


        }
    }
}

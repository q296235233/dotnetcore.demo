using dotnetcore.core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore.core
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)//上下文选项
            : base(options)
        { }

        public DbSet<User> Users { get; set; }  //初始化值

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(
        //        @"server=localhost;Initial Catalog=user_demo;Persist Security Info=True;User ID=root;Password=123456;");
        //}

    }
}
        
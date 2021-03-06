﻿using Blog.Common.Constants;
using Blog.Core.Domains.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Extensions
{
    using static AdminConstants;

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Admin.USER_ADMIN_ID,
                    UserName = Admin.USERNAME,
                    NormalizedUserName = Admin.USERNAME,
                    Email = Admin.EMAIL,
                    NormalizedEmail = Admin.EMAIL,
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, Admin.PASSWORD),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = string.Empty
                }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = Admin.ADMIN_ROLE_ID,
                    Name = Admin.ROLE,
                    NormalizedName ="ADMIN",
                    ConcurrencyStamp = string.Empty
                },
                new Role
                {
                    Id = Admin.MEMBER_ROLE_ID,
                    Name = "Member",
                    NormalizedName = "MEMBER",
                    ConcurrencyStamp = string.Empty
                }
            );
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    UserId = Admin.USER_ADMIN_ID,
                    RoleId = Admin.ADMIN_ROLE_ID
                }
            );
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RealEstateApp.Models.User;
using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Context{

    public class AppUserContext : IdentityDbContext<User,Role,string,
        UserClaim,UserRole,Login,RoleClaim,Token>{
        public AppUserContext(DbContextOptions<AppUserContext> options) : base(options){ 
        }

        protected override void OnModelCreating(ModelBuilder builder){
             base.OnModelCreating(builder);
            
            builder.Entity<User>(b =>{
                b.ToTable("Users");

                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                .WithOne(e => e.User)
                .HasForeignKey(uc => uc.UserId)
                .IsRequired();

                 // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                .WithOne(e => e.User)
                .HasForeignKey(ul => ul.UserId)
                .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                .WithOne(e => e.User)
                .HasForeignKey(ut => ut.UserId)
                .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();


            });

            builder.Entity<Role>(b =>{
                b.ToTable("Roles");
            });

            builder.Entity<UserClaim>(b =>{
                b.ToTable("UserClaims");
            });

            builder.Entity<UserRole>(b =>{
                b.ToTable("UserRoles");
            });

            builder.Entity<Login>(b =>{
                b.ToTable("Logins");
            });

            builder.Entity<RoleClaim>(b =>{
                b.ToTable("RoleClaims");
            });

            builder.Entity<Token>(b =>{
                b.ToTable("Tokens");
            });



 

        }
         
    }


}
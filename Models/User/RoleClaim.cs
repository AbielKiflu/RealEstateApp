using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class RoleClaim:IdentityRoleClaim<string>
{

     public virtual Role? Role { get; set; }
   
}


}
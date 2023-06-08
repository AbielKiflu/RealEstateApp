using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class Role:IdentityRole<string>
{
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<RoleClaim> RoleClaims { get; set; }
  
}


}
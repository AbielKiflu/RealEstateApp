using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class User:IdentityUser
{

    public virtual ICollection<UserClaim> Claims { get; set; }
    public virtual ICollection<Login> Logins { get; set; }
    public virtual ICollection<Token> Tokens { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }


   
}


}

using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class UserClaim:IdentityUserClaim<string>
{

    public virtual User? User { get; set; }
   
}


}
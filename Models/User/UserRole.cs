using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class UserRole:IdentityUserRole<string>
{

    public virtual User User { get; set; }
    public virtual Role Role { get; set; }
   
}


}

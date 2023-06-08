using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class Token:IdentityUserToken<string>
{
      public virtual User? User { get; set; }
   
}


}
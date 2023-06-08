using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Models.User
{

 public class Login:IdentityUserLogin<string>
{
     public virtual User? User { get; set; }

   
}


}
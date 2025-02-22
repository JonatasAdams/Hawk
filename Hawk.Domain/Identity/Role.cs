using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Hawk.Domain.Entities

{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}
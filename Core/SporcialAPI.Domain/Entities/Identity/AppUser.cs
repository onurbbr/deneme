﻿using Microsoft.AspNetCore.Identity;

namespace SporcialAPI.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
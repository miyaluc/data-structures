﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class26demo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthday
        {
            get; set;
        }
    }
}

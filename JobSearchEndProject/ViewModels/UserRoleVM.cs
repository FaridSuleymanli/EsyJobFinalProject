﻿using JobSearchEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels
{
    public class UserRoleVM
    {
        public AppUser User { get; set; }
        public IList<string> UserRoles { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace UserManagementCrudApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

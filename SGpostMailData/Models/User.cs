﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGpostMailData.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string EndpointId { get; set; }
    }
}
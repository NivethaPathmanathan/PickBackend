﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pick.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public String Complaint { get; set; }

        public int StatusId { get; set; }
    }
}

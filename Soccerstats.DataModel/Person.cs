﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soccerstats.Data
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

    }
}
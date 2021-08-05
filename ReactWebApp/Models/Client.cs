﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactWebApp.Models
{
    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Thing> Things { get; set; }
    }
}
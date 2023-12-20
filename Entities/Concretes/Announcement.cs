﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Announcement : Entity<Guid>
    {
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
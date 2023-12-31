﻿using Core.Entities;
using Entities.Concretes.CrossTables;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class LiveContent :Content
    {
        public Guid CourseId { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<CourseLiveContent> Courses { get; set; }
    }
}
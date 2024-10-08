﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string description)
        {
            this.description = description;
            CreatedAt = DateTime.Now;
        }
        public string description { get; private set; }

        public DateTime CreatedAt { get; private set; }
    }
}

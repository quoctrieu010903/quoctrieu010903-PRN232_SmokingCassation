﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmokingCessation.Core.Base;

namespace SmokingCessation.Domain.Entities
{
    public class Achievement  : BaseEntity
    {
        public string Title { get; set; }
        public String Description { get; set; }
        public string IconUrl { get; set; }
        public List<UserAchievement> UserAchievements { get; set; }
    }
}

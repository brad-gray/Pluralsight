﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight_Nulls
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }

        //public PlayerCharacter()
        //{
        //    DateOfBirth = null;
        //    DaysSinceLastLogin = null;
        //}
    }
}
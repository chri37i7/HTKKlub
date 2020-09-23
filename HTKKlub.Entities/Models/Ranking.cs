﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HTKKlub.Entities.Models
{
    public partial class Ranking
    {
        public int PkRankId { get; set; }
        public int FkMemberId { get; set; }
        public int Points { get; set; }

        public virtual Member FkMember { get; set; }
    }
}
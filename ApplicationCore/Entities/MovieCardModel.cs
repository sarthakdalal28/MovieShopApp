﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MovieCardModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public string Overview { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Web.Models
{
    public class QuizzAnswer
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsCorrect { get; set; }
    }
}

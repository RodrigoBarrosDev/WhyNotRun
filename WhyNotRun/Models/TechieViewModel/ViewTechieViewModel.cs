﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhyNotRun.Models.TechieViewModel
{
    public class ViewTechieViewModel
    {
        public string Name { get; set; }

        public ViewTechieViewModel(Techie techie)
        {
            Name = techie.Name;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomasosPizzeria.Entities;

namespace TomasosPizzeria.Models.ViewModels
{
    public class MatrattViewModel
    {
        public IEnumerable<Matratt> Matratter { get; set; }
    }
}

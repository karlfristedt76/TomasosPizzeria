﻿using System;
using System.Collections.Generic;

namespace TomasosPizzeria.Models
{
    public partial class MatrattProdukt
    {
        public int MatrattId { get; set; }
        public int ProduktId { get; set; }

        public Matratt Matratt { get; set; }
        public Produkt Produkt { get; set; }
    }
}

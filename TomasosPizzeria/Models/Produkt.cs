﻿using System;
using System.Collections.Generic;

namespace TomasosPizzeria.Models
{
    public partial class Produkt
    {
        public Produkt()
        {
            MatrattProdukt = new HashSet<MatrattProdukt>();
        }

        public int ProduktId { get; set; }
        public string ProduktNamn { get; set; }

        public ICollection<MatrattProdukt> MatrattProdukt { get; set; }
    }
}

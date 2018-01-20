﻿using System.Collections.Generic;
using TomasosPizzeria.Models;

namespace TomasosPizzeria.Entities
{
    public partial class Matratt
    {
        public Matratt()
        {
            BestallningMatratt = new HashSet<BestallningMatratt>();
            MatrattProdukt = new HashSet<MatrattProdukt>();
        }

        public int MatrattId { get; set; }
        public string MatrattNamn { get; set; }
        public string Beskrivning { get; set; }
        public int Pris { get; set; }
        public int MatrattTyp { get; set; }

        public MatrattTyp MatrattTypNavigation { get; set; }
        public ICollection<BestallningMatratt> BestallningMatratt { get; set; }
        public ICollection<MatrattProdukt> MatrattProdukt { get; set; }
    }
}
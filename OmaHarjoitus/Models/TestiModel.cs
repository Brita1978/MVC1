using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmaHarjoitus.Models
{
    public class TestiModel
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Osoite { get; set; }
        public int Esimies { get; set; }
        public int HenkiloID { get; set; }

        public string Nimi { get; set; }
        public string Status { get; set; }

        public int ProjektiID { get; set; }

        public int TuntiID { get; set; }
        public DateTime PVM { get; set; }

        public virtual Henkilo Henkilo { get; set;}
        public virtual Projekti Projekti { get; set; }
        public virtual Tunti Tunti { get; set; }

        

    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OmaHarjoitus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tunti
    {
        public int TuntiID { get; set; }
        public Nullable<int> ProjektiID { get; set; }
        public Nullable<int> HenkiloID { get; set; }
        public Nullable<System.DateTime> Pvm { get; set; }
        public Nullable<decimal> ProjektiTunnit { get; set; }
    
        public virtual Henkilo Henkilo { get; set; }
        public virtual Projekti Projekti { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme1.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class MentalOzellikler
    {
        public double Yetenek { get; set; }
        public double Iletisim { get; set; }
        public double Kararlılık { get; set; }
        public double Konsantrasyon { get; set; }
        public int SporcuId { get; set; }
    
        public virtual Sporcu Sporcu { get; set; }
    }
}

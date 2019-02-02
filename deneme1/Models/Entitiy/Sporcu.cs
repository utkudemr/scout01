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
    
    public partial class Sporcu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sporcu()
        {
            this.Makale = new HashSet<Makale>();
            this.FizikselOzellikler = new HashSet<FizikselOzellikler>();
            this.MentalOzellikler = new HashSet<MentalOzellikler>();
            this.TaktikselOzellikler = new HashSet<TaktikselOzellikler>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TakımId { get; set; }
        public Nullable<System.DateTime> Dtarihi { get; set; }
        public double Puan { get; set; }
        public int TiklamaSayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FizikselOzellikler> FizikselOzellikler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MentalOzellikler> MentalOzellikler { get; set; }
        public virtual Takim Takim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaktikselOzellikler> TaktikselOzellikler { get; set; }
    }
}
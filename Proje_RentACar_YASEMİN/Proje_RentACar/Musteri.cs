//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje_RentACar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            this.KiradakiAraclar = new HashSet<KiradakiAraclar>();
            this.Raporlar = new HashSet<Raporlar>();
        }
    
        public int ID { get; set; }
        public string TCNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DTarih { get; set; }
        public string Meslek { get; set; }
        public string CepNo { get; set; }
        public string EvIsTelNo { get; set; }
        public string EPosta { get; set; }
        public string Adres { get; set; }
        public Nullable<int> EhliyetNo { get; set; }
        public string EhliyetTur { get; set; }
        public string Notlar { get; set; }
        public byte[] Resim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KiradakiAraclar> KiradakiAraclar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Raporlar> Raporlar { get; set; }
    }
}

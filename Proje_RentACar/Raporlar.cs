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
    
    public partial class Raporlar
    {
        public int ID { get; set; }
        public Nullable<int> ArızaliAracID { get; set; }
        public string Plaka { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public string Ariza { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<decimal> Masraf { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
    
        public virtual Araclar Araclar { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
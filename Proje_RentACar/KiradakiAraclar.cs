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
    
    public partial class KiradakiAraclar
    {
        public int ID { get; set; }
        public Nullable<int> AracID { get; set; }
        public string AracPlaka { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public Nullable<int> AracYil { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public Nullable<System.DateTime> AlisTarih { get; set; }
        public Nullable<System.DateTime> VerisTarih { get; set; }
        public string TcNo { get; set; }
        public string Telefon { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
    
        public virtual Araclar Araclar { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}

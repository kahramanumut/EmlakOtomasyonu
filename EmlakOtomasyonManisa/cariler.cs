//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmlakOtomasyonManisa
{
    using System;
    using System.Collections.Generic;
    
    public partial class cariler
    {
        public cariler()
        {
            this.evler = new HashSet<evler>();
            this.evler1 = new HashSet<evler>();
        }
    
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public Nullable<int> yas { get; set; }
        public string adres { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string cariNotu { get; set; }
        public Nullable<bool> cinsiyet { get; set; }
    
        public virtual ICollection<evler> evler { get; set; }
        public virtual ICollection<evler> evler1 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasaMenu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hesap
    {
        public int id { get; set; }
        public double Total { get; set; }
        public int gun { get; set; }
        public int ay { get; set; }
        public int yil { get; set; }
        public int saat { get; set; }
        public int dakika { get; set; }
        public int saniye { get; set; }
        public int MId { get; set; }
    
        public virtual masalar masalar { get; set; }
    }
}

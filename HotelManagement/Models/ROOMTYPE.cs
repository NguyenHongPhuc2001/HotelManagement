//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROOMTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOMTYPE()
        {
            this.ROOMs = new HashSet<ROOM>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> max_guest { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM> ROOMs { get; set; }
    }
}

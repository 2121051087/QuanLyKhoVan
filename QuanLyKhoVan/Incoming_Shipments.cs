//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoVan
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incoming_Shipments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incoming_Shipments()
        {
            this.Incoming_Shipment_Detail = new HashSet<Incoming_Shipment_Detail>();
        }
    
        public int Shipment_ID { get; set; }
        public Nullable<int> Warehouse_ID { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
        public Nullable<System.DateTime> NgayNhapHang { get; set; }
    
        public virtual Suppliers Suppliers { get; set; }
        public virtual Warehouses Warehouses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incoming_Shipment_Detail> Incoming_Shipment_Detail { get; set; }
    }
}

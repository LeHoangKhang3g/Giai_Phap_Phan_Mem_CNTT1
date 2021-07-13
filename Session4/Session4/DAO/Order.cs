//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public long ID { get; set; }
        public long TransactionTypeID { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public Nullable<long> SourceWarehouseID { get; set; }
        public Nullable<long> DestinationWarehouseID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}

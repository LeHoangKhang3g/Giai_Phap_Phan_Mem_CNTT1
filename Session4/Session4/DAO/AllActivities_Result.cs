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
    
    public partial class AllActivities_Result
    {
        public long ID { get; set; }
        public string Part_Name { get; set; }
        public string Transaction_Type { get; set; }
        public System.DateTime Transaction_Date { get; set; }
        public decimal Amount { get; set; }
        public Nullable<long> SourceWarehouseID { get; set; }
        public Nullable<long> DestinationWarehouseID { get; set; }
    }
}

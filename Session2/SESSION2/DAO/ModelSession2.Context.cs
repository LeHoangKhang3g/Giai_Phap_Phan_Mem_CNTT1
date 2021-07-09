﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Session2Entities : DbContext
    {
        public Session2Entities()
            : base("name=Session2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AssetGroup> AssetGroups { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<ChangedPart> ChangedParts { get; set; }
        public virtual DbSet<DepartmentLocation> DepartmentLocations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmergencyMaintenance> EmergencyMaintenances { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<SELECT_EM_Result> SELECT_EM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SELECT_EM_Result>("SELECT_EM");
        }
    
        public virtual ObjectResult<AssetOfEmloyee_Result> AssetOfEmloyee(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AssetOfEmloyee_Result>("AssetOfEmloyee", idParameter);
        }
    
        public virtual int SEND_REPORT(Nullable<long> assetID, Nullable<long> priorityID, string decriptionEmergency, string otherConsideration, Nullable<System.DateTime> emReportDate, Nullable<System.DateTime> emStarDate, string emTechnicianNote)
        {
            var assetIDParameter = assetID.HasValue ?
                new ObjectParameter("assetID", assetID) :
                new ObjectParameter("assetID", typeof(long));
    
            var priorityIDParameter = priorityID.HasValue ?
                new ObjectParameter("priorityID", priorityID) :
                new ObjectParameter("priorityID", typeof(long));
    
            var decriptionEmergencyParameter = decriptionEmergency != null ?
                new ObjectParameter("decriptionEmergency", decriptionEmergency) :
                new ObjectParameter("decriptionEmergency", typeof(string));
    
            var otherConsiderationParameter = otherConsideration != null ?
                new ObjectParameter("otherConsideration", otherConsideration) :
                new ObjectParameter("otherConsideration", typeof(string));
    
            var emReportDateParameter = emReportDate.HasValue ?
                new ObjectParameter("emReportDate", emReportDate) :
                new ObjectParameter("emReportDate", typeof(System.DateTime));
    
            var emStarDateParameter = emStarDate.HasValue ?
                new ObjectParameter("emStarDate", emStarDate) :
                new ObjectParameter("emStarDate", typeof(System.DateTime));
    
            var emTechnicianNoteParameter = emTechnicianNote != null ?
                new ObjectParameter("emTechnicianNote", emTechnicianNote) :
                new ObjectParameter("emTechnicianNote", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SEND_REPORT", assetIDParameter, priorityIDParameter, decriptionEmergencyParameter, otherConsiderationParameter, emReportDateParameter, emStarDateParameter, emTechnicianNoteParameter);
        }
    
        public virtual ObjectResult<AssetOfEmloyees_Result> AssetOfEmloyees(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AssetOfEmloyees_Result>("AssetOfEmloyees", idParameter);
        }
    
        public virtual ObjectResult<Asset_Emloyees_Result> Asset_Emloyees(Nullable<long> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Asset_Emloyees_Result>("Asset_Emloyees", idParameter);
        }
    }
}

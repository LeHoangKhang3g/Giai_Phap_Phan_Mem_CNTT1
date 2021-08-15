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
    
    public partial class Session6Entities : DbContext
    {
        public Session6Entities()
            : base("name=Session6Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<DepartmentLocation> DepartmentLocations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmergencyMaintenance> EmergencyMaintenances { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    
        public virtual ObjectResult<GetDepartment_Result> GetDepartment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDepartment_Result>("GetDepartment");
        }
    
        public virtual ObjectResult<Nullable<decimal>> GetMaxSpendInTime(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("GetMaxSpendInTime", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> GetMinSpendInTime(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("GetMinSpendInTime", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetMonthWithCompleteEMInYear(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetMonthWithCompleteEMInYear", yearParameter);
        }
    
        public virtual ObjectResult<GetSpendingByDepartmentInTime_Result> GetSpendingByDepartmentInTime(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSpendingByDepartmentInTime_Result>("GetSpendingByDepartmentInTime", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetYearWithCompleteEM()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetYearWithCompleteEM");
        }
    
        public virtual ObjectResult<HighestCost_Result> HighestCost(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HighestCost_Result>("HighestCost", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<MostNumber_Result> MostNumber(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostNumber_Result>("MostNumber", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<HighestCosts_Result> HighestCosts(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HighestCosts_Result>("HighestCosts", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<MostNumbers_Result> MostNumbers(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostNumbers_Result>("MostNumbers", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<CostlyAssets_Result> CostlyAssets(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CostlyAssets_Result>("CostlyAssets", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<SpendingRatio_Result> SpendingRatio(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpendingRatio_Result>("SpendingRatio", yearParameter);
        }
    
        public virtual ObjectResult<MonthlySpending_Result> MonthlySpending(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MonthlySpending_Result>("MonthlySpending", yearParameter);
        }
    
        public virtual ObjectResult<MonthlySpendings_Result> MonthlySpendings(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MonthlySpendings_Result>("MonthlySpendings", yearParameter);
        }
    
        public virtual ObjectResult<AssetNames_Result> AssetNames()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AssetNames_Result>("AssetNames");
        }
    
        public virtual ObjectResult<FIFO_Result> FIFO(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FIFO_Result>("FIFO", warehouseParameter);
        }
    
        public virtual ObjectResult<LIFO_Result> LIFO(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LIFO_Result>("LIFO", warehouseParameter);
        }
    
        public virtual ObjectResult<MinimumFirst_Result> MinimumFirst(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MinimumFirst_Result>("MinimumFirst", warehouseParameter);
        }
    
        public virtual ObjectResult<string> PartNames(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PartNames", warehouseParameter);
        }
    
        public virtual ObjectResult<GetPartNames_Result> GetPartNames(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPartNames_Result>("GetPartNames", warehouseParameter);
        }
    
        public virtual ObjectResult<Warehouse_Result> Warehouse()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Warehouse_Result>("Warehouse");
        }
    
        public virtual ObjectResult<FI_FO_Result> FI_FO(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FI_FO_Result>("FI_FO", warehouseParameter);
        }
    
        public virtual ObjectResult<LI_FO_Result> LI_FO(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LI_FO_Result>("LI_FO", warehouseParameter);
        }
    
        public virtual ObjectResult<Minimum_First_Result> Minimum_First(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Minimum_First_Result>("Minimum_First", warehouseParameter);
        }
    
        public virtual ObjectResult<Get_PartName_Result> Get_PartName(Nullable<long> warehouse)
        {
            var warehouseParameter = warehouse.HasValue ?
                new ObjectParameter("warehouse", warehouse) :
                new ObjectParameter("warehouse", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_PartName_Result>("Get_PartName", warehouseParameter);
        }
    }
}

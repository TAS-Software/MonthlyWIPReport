﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonthlyWIPReport
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class thas01ReportEntities : DbContext
    {
        public thas01ReportEntities()
            : base("name=thas01ReportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<THAS_ExcelExport_WIPEvaluationReport_Result> THAS_ExcelExport_WIPEvaluationReport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<THAS_ExcelExport_WIPEvaluationReport_Result>("THAS_ExcelExport_WIPEvaluationReport");
        }
    }
}
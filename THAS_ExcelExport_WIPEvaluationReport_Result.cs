//------------------------------------------------------------------------------
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
    
    public partial class THAS_ExcelExport_WIPEvaluationReport_Result
    {
        public string WorksOrderNumber { get; set; }
        public string WorksOrderSuffix { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public string MethodVersion { get; set; }
        public decimal BatchQuantity { get; set; }
        public Nullable<decimal> WIPQuantity { get; set; }
        public Nullable<decimal> PlannedMaterialCost1 { get; set; }
        public Nullable<decimal> PlannedSubcontractCost1 { get; set; }
        public Nullable<decimal> PlannedRunCost1 { get; set; }
        public Nullable<decimal> PlannedSetCost1 { get; set; }
        public Nullable<decimal> ActualMaterialCost { get; set; }
        public Nullable<decimal> ActualSubcontractCost { get; set; }
        public Nullable<decimal> ActualRunCost { get; set; }
        public Nullable<decimal> ActualSetCost { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<int> PeriodNumber { get; set; }
        public System.DateTime Expr1 { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> LowerMaterialCost { get; set; }
        public Nullable<decimal> LowerSubcontractCost { get; set; }
        public Nullable<decimal> LowerRunCost { get; set; }
        public Nullable<decimal> LowerSetCost { get; set; }
    }
}

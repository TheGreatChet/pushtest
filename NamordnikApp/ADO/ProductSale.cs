//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NamordnikApp.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSale
    {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public int ProductID { get; set; }
        public System.DateTime SaleDate { get; set; }
        public int ProductCount { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Product Product { get; set; }
    }
}
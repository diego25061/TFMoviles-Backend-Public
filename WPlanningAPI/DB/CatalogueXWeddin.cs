//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPlanningAPI.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatalogueXWeddin
    {
        public int CatalogueXWeddingId { get; set; }
        public int CatalogueId { get; set; }
        public int WeddingId { get; set; }
    
        public virtual Catalogue Catalogue { get; set; }
        public virtual Wedding Wedding { get; set; }
    }
}
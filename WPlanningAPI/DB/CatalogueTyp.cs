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
    
    public partial class CatalogueTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogueTyp()
        {
            this.Catalogue = new HashSet<Catalogue>();
        }
    
        public int CatalogueTypeId { get; set; }
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public string BriefDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catalogue> Catalogue { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labWebAPIAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuyProduct()
        {
            this.Purchase_Buy_Product = new HashSet<Purchase_Buy_Product>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string unit { get; set; }
        public Nullable<double> default_price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Buy_Product> Purchase_Buy_Product { get; set; }
    }
}

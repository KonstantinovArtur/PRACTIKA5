//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRACTIKA5
{
    using System;
    using System.Collections.Generic;
    
    public partial class DescriptionTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DescriptionTour()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int DescriptionTour_ID { get; set; }
        public Nullable<int> NumDays { get; set; }
        public Nullable<int> ID_FlightInfo { get; set; }
        public Nullable<int> ID_Countries { get; set; }
    
        public virtual Countries Countries { get; set; }
        public virtual FlightInfo FlightInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
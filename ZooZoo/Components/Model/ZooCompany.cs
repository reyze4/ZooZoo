//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooZoo.Components.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZooCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZooCompany()
        {
            this.ListAnimal = new HashSet<ListAnimal>();
        }
    
        public int ID { get; set; }
        public string Address { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string Director { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListAnimal> ListAnimal { get; set; }
    }
}

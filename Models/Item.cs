namespace OnboardingRecycle.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Classifications = new HashSet<Classification>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(512)]
        public string method { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classification> Classifications { get; set; }
    }
}

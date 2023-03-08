namespace OnboardingRecycle.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public string Id { get; set; }

        [Required]
        [StringLength(128)]
        public string password { get; set; }
    }
}

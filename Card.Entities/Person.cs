using System.ComponentModel;

namespace Card.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Ad")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Soyad")]
        public string Surname { get; set; }

        [Required]
        [StringLength(11)]
        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [StringLength(255)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(250)]
        [DisplayName("Þirket adý")]
        public string Company { get; set; }
    }
}

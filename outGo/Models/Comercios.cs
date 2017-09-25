namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Comercios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comercios()
        {
            this.facturas = new HashSet<Facturas>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string ublicacion { get; set; }
        [Required]
        public string tipo { get; set; }

        public virtual ICollection<Facturas> facturas { get; set; }
    }
}

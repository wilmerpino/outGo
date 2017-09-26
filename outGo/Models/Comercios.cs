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
            this.Facturas = new HashSet<Facturas>();
        }

        public enum Tipo{
            Supermercado,
            Ferretería,
            Restaurant,
            Servicios
        };


        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Ublicacion { get; set; }
        [Required]
        public string TipoComercio { get; set; }

        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}

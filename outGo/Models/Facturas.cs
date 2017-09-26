namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas()
        {
            this.Pagos = new HashSet<Pagos>();
            this.Relaciones = new HashSet<Relaciones>();
            this.Detalles = new List<Detalles>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int IdComercio { get; set; }

        [Required]
        public string NumFactura { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double MontoPesos { get; set; }

        [DataType(DataType.Currency)]
        public Nullable<double> MontoDolares { get; set; }

        [DataType(DataType.Currency)]
        public Nullable<double> ComisionDolares { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Observaciones { get; set; }

        [ForeignKey("IdComercio")]
        public virtual Comercios Comercios { get; set; }

        public virtual ICollection<Pagos> Pagos { get; set; }

        public virtual ICollection<Relaciones> Relaciones { get; set; }

        public virtual ICollection<Detalles> Detalles { get; set; }
    }
}

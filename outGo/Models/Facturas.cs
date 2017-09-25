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
            this.pagos = new HashSet<Pagos>();
            this.relaciones = new HashSet<Relaciones>();
            this.detalles = new List<Detalles>();
        }

        [Key]
        public int id { get; set; }

        [Required]
        public int id_comercio { get; set; }

        [Required]
        public string num_factura { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime fecha { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double monto_pesos { get; set; }

        [DataType(DataType.Currency)]
        public Nullable<double> monto_dolares { get; set; }

        [DataType(DataType.Currency)]
        public Nullable<double> comision_dolares { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string detalle { get; set; }

        [ForeignKey("id_comercio")]
        public virtual Comercios comercios { get; set; }

        public virtual ICollection<Pagos> pagos { get; set; }

        public virtual ICollection<Relaciones> relaciones { get; set; }

        public virtual ICollection<Detalles> detalles { get; set; }
    }
}

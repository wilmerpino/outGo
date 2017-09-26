namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pagos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdFactura { get; set; }

        [Required]
        public Nullable<int> IdPersona { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double MontoPagado { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Fecha { get; set; }

        public virtual Facturas Facturas { get; set; }
        public virtual Personas Personas { get; set; }
    }
}

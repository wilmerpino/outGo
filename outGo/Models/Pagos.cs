namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pagos
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int id_factura { get; set; }

        [Required]
        public Nullable<int> id_persona { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double monto_pagado { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime fecha { get; set; }

        public virtual Facturas facturas { get; set; }
        public virtual Personas personas { get; set; }
    }
}

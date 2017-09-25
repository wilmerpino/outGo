namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Detalles
    {
        public int id_factura { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string tipo_gasto { get; set; }

        [Required]
        public double monto { get; set; }

        public virtual Facturas facturas { get; set; }
    }
}

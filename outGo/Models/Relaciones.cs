namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Relaciones
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int id_factura { get; set; }
        [Required]
        public double monto { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string descripcion { get; set; }
        public int id_persona { get; set; }
        public Nullable<bool> gasto_personal { get; set; }

        public virtual Facturas facturas { get; set; }
        public virtual Personas personas { get; set; }
    }
}

namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Relaciones
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdFactura { get; set; }
        [Required]
        public double Monto { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Descripcion { get; set; }
        public int IdPersona { get; set; }
        public Nullable<bool> IsGastoPersonal { get; set; }

        public virtual Facturas Facturas { get; set; }
        public virtual Personas Personas { get; set; }
    }
}

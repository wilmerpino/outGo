namespace outGo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Detalles
    {
        public enum Tipo
        {
            Comida, 
            Charcuteria,
            HigienePersonal,
            Aseso,
            Legumbres,
            Golosinas,
            Bebidas
        }
           
        public int IdFactura { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string TipoGasto { get; set; }

        [Required]
        public double Monto { get; set; }

        [ForeignKey("IdFactura")]
        public virtual Facturas Facturas { get; set; }
    }
}

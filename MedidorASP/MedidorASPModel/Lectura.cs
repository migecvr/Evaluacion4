//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedidorASPModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lectura
    {
        public int IdLectura { get; set; }
        public string Fecha { get; set; }
        public Nullable<int> Hora { get; set; }
        public Nullable<int> Minuto { get; set; }
        public Nullable<double> Consumo { get; set; }
        public int IdMedidor { get; set; }
    
        public virtual Medidor Medidor { get; set; }
    }
}

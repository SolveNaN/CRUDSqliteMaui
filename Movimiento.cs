﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFinanzasMaui
{
    public class Movimiento
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }//Ingreso Egreso
        public double? Valor { get; set; }
        public DateTime Fecha { get; set; }=DateTime.Now;
    }

}

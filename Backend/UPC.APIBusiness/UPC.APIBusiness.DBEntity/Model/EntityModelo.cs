using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class EntityModelo : EntityBase
    {
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string DescripModelo { get; set; }
        public int IdCarroceria { get; set; }
        public int IdCombustible { get; set; }
        public decimal Motor { get; set; }
        public int PotenciaHP { get; set; }
        public int PotenciaRPM { get; set; }
        public string CodColores { get; set; }

    }
}

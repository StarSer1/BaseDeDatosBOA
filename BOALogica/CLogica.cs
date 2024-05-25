using System;
using System.Collections.Generic;
using BOAEntidad;
using BOADatos;

namespace BOALogica
{
    public class CLogica
    {
        private CDatos datos;

        public CLogica()
        {
            datos = new CDatos();
        }
        //xd
        public List<Computadora> ObtenerComputadoras()
        {
            return datos.ObtenerComputadoras();
        }
    }
}

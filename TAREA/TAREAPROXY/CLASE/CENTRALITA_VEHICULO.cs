using System;
using System.Collections.Generic;
using System.Text;

namespace TAREAPROXY.CLASE
{
   
        public class CENTRALITA_VEHICULO
        {

            private int codigoLlave;
            private int codigoSeguridad;

            public CENTRALITA_VEHICULO(int codigoLlave, int codigoSeguridad)
            {
                this.codigoLlave = codigoLlave;
                this.codigoSeguridad = codigoSeguridad;
            }

            public int CodigoLlave
            {
                get
                {
                    return codigoLlave;
                }
            }

            public int CodigoSeguridad
            {
                get
                {
                    return codigoSeguridad;
                }
            }
        }
    
}

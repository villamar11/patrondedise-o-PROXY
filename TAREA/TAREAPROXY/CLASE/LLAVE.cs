using System;
using System.Collections.Generic;
using System.Text;

namespace TAREAPROXY.CLASE

    {
        public abstract class LLAVE
        {
            // Código de la llave
            protected int codigoLlave;

            // Propiedad de sólo lectura para obtener el código de la llave
            public int CodigoLlave
            {
                get
                {
                    return codigoLlave;
                }
            }

            // Métodos abstractos que implementarán el elemento real y el proxy
            public abstract void RealizarContacto(CENTRALITA_VEHICULO centralita);
            public abstract bool LlaveCorrecta(int codigoLlave);
        }
    }



using System;
using System.Collections.Generic;
using System.Text;

namespace TAREAPROXY.CLASE
{

    public class LLAVE_REAL : LLAVE
    {
        public LLAVE_REAL()
        {
        }
        public LLAVE_REAL(int codigoLlave)
        {
            this.codigoLlave = codigoLlave;
        }


        public override void RealizarContacto(CENTRALITA_VEHICULO centralita)
        {
            if (LlaveCorrecta(centralita.CodigoLlave))
                Console.WriteLine("Contacto realizado");
            else
                Console.WriteLine("Código de llave inválido");
        }

        // Comprueba que el código proporcionado coincide con el de la llave
        public override bool LlaveCorrecta(int codigoLlave)
        {
            return codigoLlave == this.codigoLlave;
        }
    }
    
}

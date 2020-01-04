using System;
using System.Collections.Generic;
using System.Text;

namespace TAREAPROXY.CLASE
{
    public class LLAVE_PROXY : LLAVE
    {
        public LLAVE_PROXY()
        {
        }
        // Referencia a la llave original
        private LLAVE llaveOriginal;

        // Constructor en el que se inyectará el objeto real
        public LLAVE_PROXY(LLAVE llave)
        {
            llaveOriginal = llave;
        }

        public override void RealizarContacto(CENTRALITA_VEHICULO centralita)
        {

            if (centralita.CodigoSeguridad > llaveOriginal.CodigoLlave.ToString().GetHashCode())
            {
                Console.WriteLine("Código de seguridad incorrecto. Abortanto arranque");
                return;
            }

            if (LlaveCorrecta(centralita.CodigoLlave))
                Console.WriteLine("Contacto realizado");
            else
                Console.WriteLine("Código de llave inválido");
        }

        public override bool LlaveCorrecta(int codigoLlave)
        {
            return llaveOriginal.LlaveCorrecta(codigoLlave);
        }
    }
}



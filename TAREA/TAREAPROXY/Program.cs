using System;
using System.Collections.Generic;
using System.Text;
using TAREAPROXY.CLASE;

namespace TAREAPROXY
{
    public class Program
    {
        static void Main(string[] args)
        {
            int codigoLlave = 532543463;
            int codigoSeguridad = 1038948470;

            CENTRALITA_VEHICULO centralita = new CENTRALITA_VEHICULO(codigoLlave, codigoSeguridad);

            LLAVE llaveSimple = new LLAVE_REAL(codigoLlave);
            llaveSimple.RealizarContacto(centralita);

            LLAVE proxy = new LLAVE_PROXY(llaveSimple);
            proxy.RealizarContacto(centralita);

            Console.ReadLine();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesComercio;

namespace Generador
{
    public static class GeneradorCodigo
    {
        /// <summary>
        /// Genera un codigo irrepetible de producto, en este caso utilizaré de longitud 5
        /// que llega a generar 3125 codigo diferentes. Seria factorial de 5 con repeticion
        /// </summary>
        /// <param name="longitudString"></param>
        /// <returns></returns>
        public static string GeneradorCodigoProducto()
        {
            string codigoGenerado;
            int longitudCodigo = 5;
            Random eleccionAleatoria = new Random();
            do
            {
                codigoGenerado = string.Empty;
                for (int i = 0; i < longitudCodigo; i++)
                {
                    int numeroAleatorio = eleccionAleatoria.Next(0, 9);

                    codigoGenerado += numeroAleatorio.ToString();
                }
            } while (Producto.ExisteCodigo(codigoGenerado)); // verifico que el codigo no exista
            return codigoGenerado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas
{
    public class Factura
    {
        private static int numeroMaximo;
        private int numero;
        private DateTime fecha;
        private List<DetalleFactura> detalles;

        public int Numero { get => numero; set => numero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<DetalleFactura> Detalles { get => detalles; set => detalles = value; }
        public static int NumeroMaximo { get => numeroMaximo; }

        /// <summary>
        /// Constructor estatico que incializa numero de factura en 0
        /// </summary>
        static Factura()
        {
            numeroMaximo = 0;
        }

        /// <summary>
        /// Constructor del tipo factura
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="detalles"></param>
        public Factura(DateTime fecha, List<DetalleFactura> detalles)
        {
            Numero = NumeroMaximo + 1;
            numeroMaximo = Numero;

            Fecha = fecha;
            Detalles = detalles;
        }

        public Factura() { }

        /// <summary>
        /// Metodo calcula total de la factura
        /// </summary>
        /// <returns>cantidad total de la factura</returns>
        public float CalcularTotal()
        {
            float total = 0;
            for (int i = 0; i < Detalles.Count; i++)
            {
                total += Detalles[i].TotalDetalle;
            }

            return total;
        }

        /// <summary>
        /// Retorna la factura completa con sus datos del detalle
        /// </summary>
        /// <returns>retorna factura completa con datos</returns>
        public string RetornarFactura()
        {
            StringBuilder stringBuilder = new StringBuilder(); // Datos Factura
            stringBuilder.AppendLine($"Factura | N° {Numero} | Fecha: {Fecha.ToString("dd/MM/yyyy")}");

            foreach (DetalleFactura item in detalles)
            {
                stringBuilder.AppendLine(item.DatosDetalle());
            }

            stringBuilder.Append($" > TOTAL: $ {this.CalcularTotal()}");

            return stringBuilder.ToString();
        }
    }
}

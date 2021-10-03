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

        static Factura()
        {
            numeroMaximo = 0;
        }

        public Factura(DateTime fecha, List<DetalleFactura> detalles)
        {
            Numero = NumeroMaximo + 1;
            numeroMaximo = Numero;

            Fecha = fecha;
            Detalles = detalles;
        }

        public Factura() { }

        public float CalcularTotal()
        {
            float total = 0;
            for (int i = 0; i < Detalles.Count; i++)
            {
                total += Detalles[i].TotalDetalle;
            }

            return total;
        }

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

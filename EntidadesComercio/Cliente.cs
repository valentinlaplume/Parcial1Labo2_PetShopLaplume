using System;
using System.Collections.Generic;
using System.Text;
using Ventas;

namespace EntidadesComercio
{
    public class Cliente : Persona
    {
        private static Dictionary<string, Cliente> listaClientes;
        private float billetera;
        private List<Factura> facturas;
        private int cantidadCompras;

        #region Constructores

        static Cliente()
        {
            ListaClientes = new Dictionary<string, Cliente>();
            ListaClientes.Add("35555555", new Cliente("Sofia", "Regino", "35555555", new Random().Next(1000, 10000)));
            ListaClientes.Add("36666666", new Cliente("Carla", "Lopez", "36666666", new Random().Next(1000, 10000)));
            ListaClientes.Add("37777777", new Cliente("Jose", "Listorti", "37777777", new Random().Next(1000, 10000)));
            ListaClientes.Add("38888888", new Cliente("Marcelo", "Tinelli", "38888888", new Random().Next(1000, 10000)));
        }

        public Cliente() : base(string.Empty, string.Empty, string.Empty)
        {
            facturas = new List<Factura>();
            CantidadCompras = 0;
            Billetera = 0;
        }

        public Cliente(string nombre,
                       string apellido,
                       string dni,
                       float billetera)
            : base(nombre, apellido, dni)
        {
            facturas = new List<Factura>();
            CantidadCompras = 0;
            Billetera = billetera;
        }

        #endregion

        #region Propiedades
        public static Dictionary<string, Cliente> ListaClientes
        {
            get => listaClientes;
            set
            {
                if (value != null)
                    listaClientes = value;
                else
                    listaClientes = new Dictionary<string, Cliente>();
            }
        }
        public List<Factura> Facturas
        {
            get => facturas;
            set
            {
                if (value != null)
                    facturas = value;
                else
                    facturas = new List<Factura>();
            }
        }
        public float Billetera
        {
            get => billetera;
            set
            {
                if (value > 0)
                    billetera = value;
                else
                    billetera = 0;
            }
        }
        public int CantidadCompras
        {
            get => cantidadCompras;
            set
            {
                if (value > 0)
                    cantidadCompras = value;
                else
                    cantidadCompras = 0;
            }
        }

        #endregion

        #region Mostrar datos
        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"{Nombre} {Apellido} | DNI: {Dni} | BILLETERA: ${Billetera}");
            return strBuilder.ToString();
        }

        public string MostrarDatosCompletosConFactura(Cliente cliente)
        {
            if (cliente != null && cliente.CantidadCompras > 0)
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append($"{MostrarDatosCompletos()}");

                foreach (Factura item in Facturas)
                {
                    strBuilder.AppendLine(item.RetornarFactura());
                }
                return strBuilder.ToString();
            }
            return $"{MostrarDatosCompletos()}\n > No posee compras por el momento.";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Generador;

namespace EntidadesComercio
{
    public class Producto
    {
        string codigo;
        string nombre;
        string caracteristicas;
        int cantidad;
        float precioUnitario;
        EnumTipoProducto tipoProducto;
        string urlImagen;
        
        public Producto(string codigo,
                        string nombre,
                        string caracteristicas,
                        EnumTipoProducto tipoProducto,
                        int cantidad,
                        float precioUnitario,
                        string urlImagen)
        {
            Codigo = codigo;
            Nombre = nombre;
            Caracteristicas = caracteristicas;
            TipoProducto = tipoProducto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            UrlImagen = urlImagen;
        }

        public Producto()
        {
            this.codigo = GeneradorCodigo.GeneradorCodigoProducto();
            Nombre = "nombrePorDefault";
            Caracteristicas = "caracteristicasPorDefault";
            Cantidad = 0;
            this.PrecioUnitario = 0;
        }


        #region Propiedades




        public string Codigo { get => codigo; private set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value.Trim(); }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public EnumTipoProducto TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public int Cantidad
        {
            get => cantidad;

            set
            {
                if (EsValidoCantidadProducto(value.ToString().Trim()))
                    cantidad = value;
                else
                    cantidad = 0;
            }
        }

        public float PrecioUnitario 
        { 
            get => precioUnitario; 
            set
            {
                if (EsValidoPrecioUnitarioProducto(value.ToString().Trim()))
                    precioUnitario = value;
                else
                    precioUnitario = 0;
            }
        }
        public string UrlImagen
        { 
            get => urlImagen; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                    urlImagen = value.Trim();
                else // sino retorna una imagen con la indicacion de no disponible
                    urlImagen = "https://i1.wp.com/www.musicapopular.cult.cu/wp-content/uploads/2017/12/imagen-no-disponible.png?fit=600%2C450";
            }
        }


        #region Validaciones
        /// <summary>
        /// Verifica si la cantidad de productos ingresados es un numero int y mayor a 0.
        /// </summary>
        /// <param name="cantidadIngresada"></param>
        /// <returns>Retorna true si ok, sino retorna false</returns>
        static public bool EsValidoCantidadProducto(string cantidadIngresada)
        {
            if (!string.IsNullOrEmpty(cantidadIngresada) &&
                int.TryParse(cantidadIngresada, out int cantidadOk) &&
                cantidadOk > 0)
                return true;
            else
                return false;
        }

        static public bool EsValidoPrecioUnitarioProducto(string precioUnitarioIngresado)
        {
            if (!string.IsNullOrEmpty(precioUnitarioIngresado) &&
                float.TryParse(precioUnitarioIngresado, out float precioUnitarioOk) &&
                precioUnitarioOk > 0)
                return true;
            else
                return false;
        }

        #endregion

        #endregion
        public string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"CODIGO: {Codigo} | NOMBRE: {Nombre} | CARACTERISTICAS: {Caracteristicas} | TIPO: {tipoProducto} | EN STOCK: {Cantidad} | UNIDAD: $ {PrecioUnitario}");
            return strBuilder.ToString();
        }

        static public bool ExisteCodigo(string codigoIngresado)
        {
            if (!string.IsNullOrEmpty(codigoIngresado))
            {
                foreach (Producto item in CoreDelSistema.ListaProductos)
                {
                    if (item.Codigo == codigoIngresado)
                        return true;
                }
            }
            return false;
        }

        static public Producto BuscarProducto(string codigoIngresado)
        {
            if (!string.IsNullOrEmpty(codigoIngresado))
            {
                foreach (Producto item in CoreDelSistema.ListaProductos)
                {
                    if (item.Codigo == codigoIngresado)
                        return item;
                }
            }
            return null;
        }
    }
}

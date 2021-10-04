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
        
        /// <summary>
        /// Constructor del tipo producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="caracteristicas"></param>
        /// <param name="tipoProducto"></param>
        /// <param name="cantidad"></param>
        /// <param name="precioUnitario"></param>
        /// <param name="urlImagen"></param>
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

        /// <summary>
        /// Constructor por default del tipo producto
        /// </summary>
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
       
        /// <summary>
        /// Propiedad que muestra y asigna cantidad, valida que la cantidad sea numerica y mayor a 0
        /// </summary>
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

        /// <summary>
        /// Propiedad obtiene y valida-asigna un precio unitario
        /// </summary>
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
        /// <summary>
        /// Propiedad url imagen, muestra, asigna pero antes valida imagen del producto, sino se le asigna una por default
        /// </summary>
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

        /// <summary>
        /// Valida que el precio unitario sea parciable y que sea mayor a 0
        /// </summary>
        /// <param name="precioUnitarioIngresado"></param>
        /// <returns>true valido, false no valido</returns>
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
        /// <summary>
        /// Muestra los datos de un producto
        /// </summary>
        /// <returns>retorna datos del producto</returns>
        public string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"CODIGO: {Codigo} | NOMBRE: {Nombre} | CARACTERISTICAS: {Caracteristicas} | TIPO: {tipoProducto} | EN STOCK: {Cantidad} | UNIDAD: $ {PrecioUnitario}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// Verifica si ya existe el codigo del producto
        /// </summary>
        /// <param name="codigoIngresado"></param>
        /// <returns>retorna true si existe codigo, false si no existe</returns>
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

        /// <summary>
        /// Busca un producto segun su codigo
        /// </summary>
        /// <param name="codigoIngresado"></param>
        /// <returns>retorna producto si lo encontro, sino retorna null</returns>
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

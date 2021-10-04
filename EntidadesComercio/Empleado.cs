using System.Text;

namespace EntidadesComercio
{
    public class Empleado : Administrador
    {
        int cantidadVentas;

        /// <summary>
        /// Constructor de tipo Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="sueldo"></param>
        /// <param name="tipoUsuario"></param>
        /// <param name="cantidadVentas"></param>
        /// <param name="urlImagen"></param>
        public Empleado(string nombre,
                        string apellido,
                        string dni,
                        string usuario,
                        string contraseña,
                        float sueldo,
                        EnumTipoUsuario tipoUsuario,
                        int cantidadVentas,
                        string urlImagen)
            : base(nombre, apellido, dni, usuario, contraseña, sueldo, tipoUsuario, urlImagen)
        {
            CantidadVentas = cantidadVentas;
        }

        public int CantidadVentas { get => cantidadVentas; set => cantidadVentas = value; }

        /// <summary>
        /// Metodo heredado obligatorio, muestra los datos de un Empleado
        /// </summary>
        /// <returns>datos empleado</returns>
        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"LEGAJO: {Legajo} | RANGO: {TipoUsuario} | {Nombre} {Apellido} DNI: {Dni} | USER:{UsuarioPropiedad} | SUELDO: ${Sueldo} | VENTAS: {CantidadVentas}");
            return strBuilder.ToString();
        }
    }
}

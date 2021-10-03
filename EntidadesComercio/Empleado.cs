using System.Text;

namespace EntidadesComercio
{
    public class Empleado : Administrador
    {
        int cantidadVentas;

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

        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"LEGAJO: {Legajo} | RANGO: {TipoUsuario} | {Nombre} {Apellido} DNI: {Dni} | USER:{UsuarioPropiedad} | SUELDO: ${Sueldo} | VENTAS: {CantidadVentas}");
            return strBuilder.ToString();
        }
    }
}

using System.Text;

namespace EntidadesComercio
{
    public class Administrador : Usuario
    {
        private float sueldo;
        /// <summary>
        /// Constructor publico de tipo Administrador
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="sueldo"></param>
        /// <param name="tipoUsuario"></param>
        /// <param name="urlImagen"></param>
        public Administrador(string nombre,
                             string apellido,
                             string dni,
                             string usuario,
                             string contraseña,
                             float sueldo,
                             EnumTipoUsuario tipoUsuario,
                             string urlImagen)
                        : base(nombre, apellido, dni, usuario, contraseña, tipoUsuario, urlImagen)
        {
            Sueldo = sueldo;
        }

        /// <summary>
        /// Propiedad sueldo, verifica si el sueldo es mayor a 0, validacion chica
        /// </summary>
        public float Sueldo 
        { 
            get => sueldo;
            set
            {
                if (value > -1)
                    sueldo = value;
                else
                    sueldo = 0;
            }
            
        }

        /// <summary>
        /// Metodo heredado obligatorio, muestra los datos de un administrador
        /// </summary>
        /// <returns>datos administrador</returns>
        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"LEGAJO: {Legajo} | RANGO: {TipoUsuario} | {Nombre} {Apellido} DNI: {Dni} | USER:{UsuarioPropiedad} | SUELDO: ${Sueldo}");
            return strBuilder.ToString();
        }


    }
}

using System.Text;

namespace EntidadesComercio
{
    public class Administrador : Usuario
    {
        private float sueldo;
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

        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"LEGAJO: {Legajo} | RANGO: {TipoUsuario} | {Nombre} {Apellido} DNI: {Dni} | USER:{UsuarioPropiedad} | SUELDO: ${Sueldo}");
            return strBuilder.ToString();
        }


    }
}

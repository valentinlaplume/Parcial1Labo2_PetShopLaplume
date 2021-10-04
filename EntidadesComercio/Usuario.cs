using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EntidadesComercio
{
    public class Usuario : Persona
    {
        private static int ultimoLegajo;

        private EnumTipoUsuario tipoUsuario;
        private string usuario;
        private string contraseña;
        private int legajo;
        string urlImagen;

        /// <summary>
        /// Constructor estatico, inicializa el ultimoLegajo en 0
        /// </summary>
        static Usuario()
        {
            ultimoLegajo = 0;
        }

        /// <summary>
        /// Constructor de tipo Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="tipoUsuario"></param>
        /// <param name="urlImagen"></param>
        public Usuario(string nombre,
                       string apellido,
                       string dni,
                       string usuario,
                       string contraseña,
                       EnumTipoUsuario tipoUsuario,
                       string urlImagen)
            : base(nombre, apellido, dni)
        {
            UsuarioPropiedad = usuario;
            Contraseña = contraseña;
            this.TipoUsuario = tipoUsuario;

            legajo = UltimoLegajo + 1;
            ultimoLegajo = legajo;
            this.UrlImagen = urlImagen;
        }

        public string UsuarioPropiedad { get => usuario; set => usuario = value.Trim(); }
        public string Contraseña { get => contraseña; set => contraseña = value.Trim(); }

        public int Legajo { get => legajo; set => legajo = value; }
        public static int UltimoLegajo { get => ultimoLegajo; }
        public EnumTipoUsuario TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        /// <summary>
        /// Propiedad que verifica la url de la imagen de perfil del usuario.
        /// Si la imagen no es valida se le asigna una por defecto (sin foto)
        /// </summary>
        public string UrlImagen 
        { 
            get => urlImagen; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.urlImagen = value.Trim();
                else
                    this.urlImagen = "https://www.ibei.org/images/4611/person_box.png";

            }
        }

        /// <summary>
        /// Metodo heredado obligatorio, muestra los datos del usuario
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"{Nombre} {Apellido} | DNI: {Dni} | USER: {UsuarioPropiedad} | RANGO: {TipoUsuario}+");
            return strBuilder.ToString();
        }

        #region BUSCAR USUARIO

        /// <summary>
        /// Busca un usuario segun su legajo
        /// </summary>
        /// <param name="legajoIngresado"></param>
        /// <returns>retorna el Usuario si lo encontro, sino retorna null</returns>
        static public Usuario BuscarUsuario(int legajoIngresado)
        {
            if (legajoIngresado <= UltimoLegajo)
            {
                foreach (KeyValuePair<string, Usuario> item in CoreDelSistema.ListaUsuarios)
                {
                    if (item.Value.Legajo == legajoIngresado)
                        return item.Value;
                }
            }
            return null;
        }
        /// <summary>
        /// Busca un usuario segun su usuario
        /// </summary>
        /// <param name="legajoIngresado"></param>
        /// <returns>retorna el Usuario si lo encontro, sino retorna null</returns>
        static public Usuario BuscarUsuario(string usuarioStr)
        {
            if (!string.IsNullOrEmpty(usuarioStr))
            {
                foreach (KeyValuePair<string, Usuario> item in CoreDelSistema.ListaUsuarios)
                {
                    if (item.Value.UsuarioPropiedad == usuarioStr.Trim())
                        return item.Value;
                }
            }
            return null;
        }

        #endregion

        #region VALIDACIONES

        /// <summary>
        /// Validacion 
        /// Verifica si el usuario y contraseña pertenecen a un trabajador registrado en el sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns>retorna true si es usuario, sino retorna false</returns>
        static public bool EsUsuario(string usuario, string contraseña)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {
                foreach (KeyValuePair<string, Usuario> item in CoreDelSistema.ListaUsuarios)
                {
                    if (item.Value.UsuarioPropiedad == usuario.Trim() &&
                        item.Value.Contraseña == contraseña.Trim())
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Valida que el dni sea numerico y que contega 8 caracteres
        /// </summary>
        /// <param name="dniIngresado"></param>
        /// <returns>true si es valido, false si no lo es</returns>
        static public bool EsValidoDni(string dniIngresado)
        {
            Regex reg = new Regex("[0-9]"); //Expresión que solo acepta números.
            if (!string.IsNullOrEmpty(dniIngresado) &&
                reg.IsMatch(dniIngresado) && dniIngresado.Length == 8)
            {
                foreach (KeyValuePair<string, Usuario> item in CoreDelSistema.ListaUsuarios)
                {
                    if (item.Value.Dni == dniIngresado) // valido que no sea dni repetido
                        return false;
                }
                return true;
            }
            return false;


        }
        /// <summary>
        /// Valida que el nombre de usuario no este registrado en el sistema
        /// </summary>
        /// <param name="dniIngresado"></param>
        /// <returns>false si el usuario ya esta registrado, sino true si se puede utilizar</returns>
        static public bool EsValidoNombreUsuario(string usuarioIngresado)
        {
            if (!string.IsNullOrEmpty(usuarioIngresado))
            {
                foreach (KeyValuePair<string, Usuario> item in CoreDelSistema.ListaUsuarios)
                {
                    if (item.Value.UsuarioPropiedad == usuarioIngresado) // valido que no sea nombre usuario repetido
                        return false;
                }
                return true;
            }
            return false;
        }

        #endregion
    }
}

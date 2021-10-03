using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EntidadesComercio
{
    public class Usuario : Persona
    {
        private static int ultimoLegajo;
        private static Usuario usuarioLogeado;
        private static Dictionary<string, Usuario> listaUsuarios;

        private EnumTipoUsuario tipoUsuario;
        private string usuario;
        private string contraseña;
        private int legajo;
        string urlImagen;

        static Usuario()
        {
            ultimoLegajo = 0;
            ListaUsuarios = new Dictionary<string, Usuario>();

            ListaUsuarios.Add("42544147", new Administrador("Valentin", "Laplume", "42544147", "Valentin.Admin", "asd111", 150000, EnumTipoUsuario.Administrador,
                                                           "https://media-exp1.licdn.com/dms/image/C4E03AQG5xI2dtwrpoQ/profile-displayphoto-shrink_200_200/0/1627946693294?e=1638403200&v=beta&t=0PrOU9STbwYfOpymnwhvGuGfj025nxxS5n5otHeIMfM"));
            ListaUsuarios.Add("32222222", new Administrador("Roman", "Riquelme", "32222222", "Roman10.Admin", "asd222", 150000, EnumTipoUsuario.Administrador,
                                                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaKTuKOC4Es3CEpLDdiryoXuWo_Aij-SAx4A&usqp=CAU"));
            ListaUsuarios.Add("99999999", new Administrador("Lucas", "Rodriguez", "99999999", "Lucas.Admin", "asd777", 150000, EnumTipoUsuario.Administrador,
                                                            ""));

            ListaUsuarios.Add("33333333", new Empleado("Homero", "Simpsons", "33333333", "Homero.Emp", "asd333", 60000, EnumTipoUsuario.Empleado, 0,
                                                        "https://i.pinimg.com/originals/bd/19/2f/bd192f2723f7d81013f04903d9e0428b.png"));
            ListaUsuarios.Add("34444444", new Empleado("Sofia", "Regino", "34444444", "Sofia.Emp", "asd444", 60000, EnumTipoUsuario.Empleado, 0, 
                                                        ""));
        }
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
        public static Dictionary<string, Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public static Usuario UsuarioLogeado { get => usuarioLogeado; set => usuarioLogeado = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public static int UltimoLegajo { get => ultimoLegajo; }
        public EnumTipoUsuario TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
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

        public override string MostrarDatosCompletos()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine($"{Nombre} {Apellido} | DNI: {Dni} | USER: {UsuarioPropiedad} | RANGO: {TipoUsuario}+");
            return strBuilder.ToString();
        }

        static public bool EsUsuario(string usuario, string contraseña)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {
                foreach (KeyValuePair<string, Usuario> item in Usuario.ListaUsuarios)
                {
                    if (item.Value.UsuarioPropiedad == usuario.Trim() &&
                        item.Value.Contraseña == contraseña.Trim())
                        return true;
                }
            }
            return false;
        }
        #region Buscar usuario

        static public Usuario BuscarUsuario(int legajoIngresado)
        {
            if (legajoIngresado <= UltimoLegajo)
            {
                foreach (KeyValuePair<string, Usuario> item in ListaUsuarios)
                {
                    if (item.Value.Legajo == legajoIngresado)
                        return item.Value;
                }
            }
            return null;
        }

        static public Usuario BuscarUsuario(string usuarioStr)
        {
            if (!string.IsNullOrEmpty(usuarioStr))
            {
                foreach (KeyValuePair<string, Usuario> item in ListaUsuarios)
                {
                    if (item.Value.UsuarioPropiedad == usuarioStr.Trim())
                        return item.Value;
                }
            }
            return null;
        }

        #endregion

        #region VALIDACIONES
        static public bool EsValidoDni(string dniIngresado)
        {
            Regex reg = new Regex("[0-9]"); //Expresión que solo acepta números.
            if (!string.IsNullOrEmpty(dniIngresado) &&
                reg.IsMatch(dniIngresado) && dniIngresado.Length == 8)
            {
                foreach (KeyValuePair<string, Usuario> item in Usuario.ListaUsuarios)
                {
                    if (item.Value.Dni == dniIngresado) // valido que no sea dni repetido
                        return false;
                }
                return true;
            }
            return false;


        }

        static public bool EsValidoNombreUsuario(string usuarioIngresado)
        {
            if (!string.IsNullOrEmpty(usuarioIngresado))
            {
                foreach (KeyValuePair<string, Usuario> item in Usuario.ListaUsuarios)
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

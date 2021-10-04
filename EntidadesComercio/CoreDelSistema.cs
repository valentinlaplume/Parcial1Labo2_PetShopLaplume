using Generador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    static public class CoreDelSistema
    {
        private static List<Producto> listaProductos;
        private static Dictionary<string, Cliente> listaClientes;

        private static Usuario usuarioLogeado;
        private static Dictionary<string, Usuario> listaUsuarios;

        /// <summary>
        /// Constructor estatico, inicializa listas y pre carga usuarios, productos, clientes
        /// </summary>
        static CoreDelSistema()
        {
            listaProductos = new List<Producto>();
            HarcodeoProductos();

            listaClientes = new Dictionary<string, Cliente>();
            HarcodeoClientes();

            ListaUsuarios = new Dictionary<string, Usuario>();
            HarcodeoTrabajadoresUsuarios();

        }

        #region USUARIOS TRABAJADORES
        /// <summary>
        /// Harcodeo de usuarios registrados, el programa inicia con usuarios pre cargados
        /// </summary>
        static private void HarcodeoTrabajadoresUsuarios()
        {
            ListaUsuarios.Add("42544147", new Administrador("Valentin", "Laplume", "42544147", "Valentin.Admin", "asd111", 150000, EnumTipoUsuario.Administrador,
                                                           "https://media-exp1.licdn.com/dms/image/C4E03AQG5xI2dtwrpoQ/profile-displayphoto-shrink_200_200/0/1627946693294?e=1638403200&v=beta&t=0PrOU9STbwYfOpymnwhvGuGfj025nxxS5n5otHeIMfM"));
            ListaUsuarios.Add("32222222", new Administrador("Roman", "Riquelme", "32222222", "Roman10.Admin", "asd222", 150000, EnumTipoUsuario.Administrador,
                                                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaKTuKOC4Es3CEpLDdiryoXuWo_Aij-SAx4A&usqp=CAU"));
            ListaUsuarios.Add("39999999", new Administrador("Lucas", "Rodriguez", "39999999", "Lucas.Admin", "asd777", 150000, EnumTipoUsuario.Administrador,
                                                            "https://avatars.githubusercontent.com/u/19439749?v=4"));

            ListaUsuarios.Add("33333333", new Empleado("Homero", "Simpsons", "33333333", "Homero.Emp", "asd333", 60000, EnumTipoUsuario.Empleado, 0,
                                                        "https://i.pinimg.com/originals/bd/19/2f/bd192f2723f7d81013f04903d9e0428b.png"));
            ListaUsuarios.Add("34444444", new Empleado("Sofia", "Regino", "34444444", "Sofia.Emp", "asd444", 60000, EnumTipoUsuario.Empleado, 0,
                                                        ""));
        }

        public static Dictionary<string, Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public static Usuario UsuarioLogeado { get => usuarioLogeado; set => usuarioLogeado = value; }
        #endregion

        #region CLIENTES
        /// <summary>
        /// Harcodeo de CLIENTES registrados, el programa inicia con CLIENTES pre cargados
        /// </summary>
        static private void HarcodeoClientes()
        {
            ListaClientes.Add("35555555", new Cliente("Sofia", "Regino", "35555555", new Random().Next(1000, 10000)));
            ListaClientes.Add("36666666", new Cliente("Carla", "Lopez", "36666666", new Random().Next(1000, 10000)));
            ListaClientes.Add("37777777", new Cliente("Jose", "Listorti", "37777777", new Random().Next(1000, 10000)));
            ListaClientes.Add("38888888", new Cliente("Marcelo", "Tinelli", "38888888", new Random().Next(1000, 10000)));
        }

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
        #endregion

        #region PRODUCTOS
        /// <summary>
        /// Harcodeo de PRODUCTOS registrados, el programa inicia con CLIENTES pre cargados
        /// </summary>
        static private void HarcodeoProductos()
        {
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Dog Chow", "Sin Colorantes para perro adulto", EnumTipoProducto.Alimento, 10, new Random().Next(50, 300),
                                            "https://statics.dinoonline.com.ar/imagenes/full_600x600_ma/2520610_f.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Unik Premium", "Para perro adulto de raza pequeña", EnumTipoProducto.Alimento, 15, new Random().Next(100, 350), // OK
                                            "https://drovenort.com.ar/wp-content/uploads/2019/04/Unik-Cachorro-Small.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Cat Chow", "Defense Plus Esterilizados para gato", EnumTipoProducto.Alimento, 20, new Random().Next(100, 350),
                                            "http://d3ugyf2ht6aenh.cloudfront.net/stores/860/952/products/alimento-gato-adultos-carne-cat-chow-1-kg-1-344611-49ecdf996a2c592e1c15644318188310-640-0.jpg"));

            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Iglu Casita", "Impermeable Para Perros O Gatos 40x30", EnumTipoProducto.Comodidad, 5, new Random().Next(1000, 2000),
                                            "https://i.pinimg.com/originals/82/0c/46/820c460e3852fd93609000f8119697d3.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Cama Colgante", "Para Ventana Para Gatos", EnumTipoProducto.Comodidad, 5, new Random().Next(1000, 1800),
                                            "https://todogatos.org/venta/wp-content/uploads/2018/09/cama-colgante-gato-2.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Cama Moises", "Tamanio: 60 x 51 x 23 cm", EnumTipoProducto.Comodidad, 12, new Random().Next(200, 300),
                                            "https://d3ugyf2ht6aenh.cloudfront.net/stores/001/149/130/products/img_6153-11-a511a03193ec3c22a116231781476279-1024-1024.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Correa Flexi", "Plastico, con botón de frenado: Sí", EnumTipoProducto.Comodidad, 7, new Random().Next(2000, 2500),
                                            "https://glee.pet/wp-content/uploads/2019/04/1757-e1623937697833.jpg"));

            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Soga", "2 Nudos, perros Cachorros", EnumTipoProducto.Juguete, 10, new Random().Next(50, 300),
                                            "https://http2.mlstatic.com/D_NQ_NP_661959-MLA44643176821_012021-O.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Pelota", "7 Cm Perros, limpia dientes", EnumTipoProducto.Juguete, 7, new Random().Next(50, 200),
                                            "http://laveteonline.com.ar/tienda/images/tbp001_ro.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Salchicha C/ Soga", "Material: Vinilo, ideal perros chicos", EnumTipoProducto.Juguete, 15, new Random().Next(50, 150),
                                            "https://kangoopet.com.ar/wp-content/uploads/2020/07/20200714_133645-rotated-e1594833465810.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Peluche", "Con Soga 17cm, de cuero", EnumTipoProducto.Juguete, 9, new Random().Next(100, 350),
                                            "https://hollywoodpetshop.com.ar/wp-content/uploads/2020/07/20200706_121441.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Hueso", "De Cuero Corb 3/4", EnumTipoProducto.Juguete, 15, new Random().Next(100, 200),
                                             "https://toquipetshop.com.ar/wp-content/uploads/2020/04/Hueso-6-7.png"));


            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Venda", "Post Operatoria, elástica", EnumTipoProducto.Farmacia, 20, 100,
                                            "https://lh3.googleusercontent.com/proxy/ReeNmmMF6mjGIIgy58ZxEd9SKGNlfC84gRsKPeWgNniUENRqwGbYSCtJsCsHfmIgfvWTEDpvbFdOq4Co0MjM7ODATRwDmpFDRCayyalXPNgD110"));

            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Bandeja Sanitaria", "Plastico, síntetico verde", EnumTipoProducto.Limpieza, 5, new Random().Next(2000, 3000),
                                            "https://centropet.com/wp-content/uploads/2020/06/955331-MLA40442230863_012020.jpg"));
            listaProductos.Add(new Producto(GeneradorCodigo.GeneradorCodigoProducto(), "Piedritas", "Sanitarias , ecologicas", EnumTipoProducto.Limpieza, 5, new Random().Next(100, 200),
                                            "https://d3ugyf2ht6aenh.cloudfront.net/stores/001/447/380/products/piedritas-sanitarias-ecologicas-grano-grueso_41-14719d15a04fb1221816164571942183-1024-1024.jpg"));
        }

        public static List<Producto> ListaProductos
        {
            get => listaProductos;
            set
            {
                if (value != null)
                    listaProductos = value;
                else
                    listaProductos = new List<Producto>(); // VER ESTO SI CAMBIAR A NULL
            }
        }

        #endregion

    }
}

namespace EntidadesComercio
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;

        /// <summary>
        /// Constructor base, padre de tipo Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        /// <summary>
        /// Metodo obligatorio abstracto para clases hijas
        /// </summary>
        /// <returns></returns>
        public abstract string MostrarDatosCompletos();


    }
}

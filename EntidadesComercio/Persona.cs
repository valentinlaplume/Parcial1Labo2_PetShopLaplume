namespace EntidadesComercio
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;

        protected Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        public abstract string MostrarDatosCompletos();


    }
}


using System.Net.Sockets;


namespace ChatACeniceros
{
    public class Usuario
    {

        private string nombre;
        private Socket socket;

        public Usuario(string nombre, Socket socket)
        {
            this.nombre = nombre;
            this.socket = socket;
        }

        public Usuario()
        {
            this.nombre = "";
            this.socket = null;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public Socket Socket { get => socket; set => socket = value; }


        public string Mostrar()
        {
            return "Usuario: "+this.nombre;

        }
    }
}

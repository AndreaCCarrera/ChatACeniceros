using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ChatACeniceros
{
    public class Servidor
    {
        Socket servidor;
        IPEndPoint localEndPoint;

        IPAddress ipAddress = IPAddress.Parse("192.168.101.250");
        // Create a TCP/IP socket.

        public void Arrancar()
        {
            servidor = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // Establecemos el EndPoint con la dirección local y el puerto 80:
            localEndPoint = new IPEndPoint(ipAddress, 15000);

            // Asocia el endPoint indicado (ip y puerto) al socket:
            servidor.Bind(localEndPoint);



            // Establece la longitud máxima de la cola de conexiones
            // pendientes que puede tener el servidor antes de empezar a rechazar conexiones:
            servidor.Listen(10);
            Console.WriteLine("Waiting for a connection..." + Environment.NewLine);

            // El programa se suspende mientras está esperando la entrada de una conexión:
            Socket conexionCliente = servidor.Accept();
            // Data buffer para almacenar los datos recibidos
            Byte[] bytes = new Byte[1024];
            string datos = null;


            // Recepción de los datos:
            conexionCliente.Receive(bytes);
            datos = Encoding.ASCII.GetString(bytes);

            // Mostramos el texto recibido:
            Console.WriteLine("Texto recibido: " + Environment.NewLine + datos);

            // Mensaje que enviaremos de respuesta al cliente:
            Byte[] msg = Encoding.ASCII.GetBytes("Petición Recibida Correctamente");
            
            // Envío de mensaje de respuesta al cliente:
            conexionCliente.Send(msg);
            
            // Apagado del socket:
            conexionCliente.Shutdown(SocketShutdown.Both);
            
            // Cierre y libera los recursos del socket:
            conexionCliente.Close();
        }
    }

}

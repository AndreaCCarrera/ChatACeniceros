using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatACeniceros
{
    public partial class Chat : Form
    {
        private Socket servidor;
        private IPEndPoint localEndPoint;
        private List<Socket> clientes = new List<Socket>();
        private bool esperarNuevoUsuario = false;

        private IPAddress ipAddress = IPAddress.Parse("192.168.101.250");

        public Chat()
        {
            InitializeComponent();
        }

        private async void btArrancar_Click(object sender, EventArgs e)
        {
            try
            {
                if (servidor == null || !servidor.IsBound)
                {
                    servidor = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    localEndPoint = new IPEndPoint(ipAddress, 15000);

                    servidor.Bind(localEndPoint);
                    servidor.Listen(10);
                    txtConversacion.Text = "Esperando conexión..." + Environment.NewLine;

                    esperarNuevoUsuario = true; // Establecer en true al arrancar
                    await Task.Run(() => EsperarConexiones());
                }
                else
                {
                    MessageBox.Show("El servidor ya está en funcionamiento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EsperarConexiones()
        {
            while (esperarNuevoUsuario)
            {
                Socket conexionCliente = null;
                try
                {
                    conexionCliente = servidor.Accept();
                    clientes.Add(conexionCliente);

                    this.Invoke(new Action(() =>
                    {
                        // Agregar usuario al ComboBox y seleccionarlo
                        comboBoxUsuarios.Items.Add("Usuario" + (clientes.IndexOf(conexionCliente) + 1));
                    }));

                    // Enviar mensaje de bienvenida al nuevo cliente
                    EnviarMensaje(conexionCliente, "¡Bienvenido a Chatdrea!");

                    Task.Run(() => GestionarCliente(conexionCliente));
                }
                catch (SocketException)
                {
                    // La excepción SocketException se lanzará cuando se cierre el servidor.
                    // Simplemente salimos del bucle y limpiamos los recursos.
                    break;
                }
                catch (Exception ex)
                {
                    // Manejar otras excepciones
                    this.Invoke(new Action(() =>
                    {
                        txtConversacion.Text += "Error: " + ex.Message + Environment.NewLine;
                    }));

                    if (conexionCliente != null && conexionCliente.Connected)
                    {
                        conexionCliente.Close();
                    }

                    clientes.Remove(conexionCliente);

                    this.Invoke(new Action(() =>
                    {
                        ActualizarComboBoxUsuarios();
                    }));
                }
            }
        }


        private void EnviarMensaje(Socket cliente, string mensaje)
        {
            try
            {
                Byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                cliente.Send(msg);
            }
            catch (SocketException ex)
            {
                // Manejar la excepción, por ejemplo, si el cliente ya no está conectado
                this.Invoke(new Action(() =>
                {
                    txtConversacion.Text += $"{Environment.NewLine}Error al enviar el mensaje de bienvenida: {ex.Message}{Environment.NewLine}";
                }));
            }
        }

        private void GestionarCliente(Socket conexionCliente)
        {
            bool bucle = true;
            try
            {
                Byte[] bytes = new Byte[1024];
                string datos = null;
                string nombreUsuario = "Usuario" + (clientes.IndexOf(conexionCliente) + 1);


                this.Invoke(new Action(() =>
                {
                    txtConversacion.Text += $"{Environment.NewLine}{nombreUsuario} se ha conectado.{Environment.NewLine}";
                    ActualizarComboBoxUsuarios();
                }));

                while (bucle)
                {

                    int tamRecepcion = conexionCliente.Receive(bytes);
                    if (tamRecepcion > 0)
                    {
                        datos = Encoding.ASCII.GetString(bytes);

                        this.Invoke(new Action(() =>
                        {
                            txtConversacion.Text += $"{Environment.NewLine}{nombreUsuario}: {datos}{Environment.NewLine}";
                        }));
                    }
                    else
                    {

                        txtConversacion.Text += $"{Environment.NewLine}{nombreUsuario} se ha desconectado {Environment.NewLine}";
                        conexionCliente.Close();
                        clientes.Remove(conexionCliente);
                        this.Invoke(new Action(() =>
                        {
                            ActualizarComboBoxUsuarios();
                        }));
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    txtConversacion.Text += "Error: " + ex.Message + Environment.NewLine;
                }));

                // Cerrar la conexión del cliente y eliminarlo de la lista
                conexionCliente.Close();
                clientes.Remove(conexionCliente);

                this.Invoke(new Action(() =>
                {
                    ActualizarComboBoxUsuarios();
                }));

                // Establecer una variable para indicar que se ha producido una excepción y salir del bucle
                bucle = false;
            }
            finally
            {
                // Asegurarse de que la variable se restablezca antes de la próxima iteración
                bucle = false;
            }
        }

            private void EnviarMensajeAClienteSeleccionado(byte[] msg)
        {
            this.Invoke(new Action(() =>
            {
                if (comboBoxUsuarios.SelectedItem != null)
                {
                    int indiceCliente = comboBoxUsuarios.SelectedIndex;
                    if (indiceCliente >= 0 && indiceCliente < clientes.Count)
                    {
                        try
                        {
                            if (clientes[indiceCliente].Connected)
                            {
                                clientes[indiceCliente].Send(msg);
                            }
                            else
                            {
                                // El cliente está desconectado
                                txtConversacion.Text += $"{Environment.NewLine}Error: El usuario seleccionado está desconectado.{Environment.NewLine}";
                            }
                        }
                        catch (Exception ex)
                        {
                            // Otra excepción relacionada con el socket
                            txtConversacion.Text += $"{Environment.NewLine}Error al enviar el mensaje: {ex.Message}{Environment.NewLine}";
                        }
                    }
                }
            }));
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Byte[] msg = Encoding.ASCII.GetBytes("Andie: "+txtMensaje.Text);
            EnviarMensajeAClienteSeleccionado(msg);

            this.Invoke(new Action(() =>
            {
                txtConversacion.Text += $"{Environment.NewLine}Yo: {txtMensaje.Text}{Environment.NewLine}";
                txtMensaje.Text = string.Empty;
            }));
        }

        private void ActualizarComboBoxUsuarios()
        {
            this.Invoke(new Action(() =>
            {
                comboBoxUsuarios.Items.Clear();
                foreach (var cliente in clientes)
                {
                    comboBoxUsuarios.Items.Add("Usuario" + (clientes.IndexOf(cliente) + 1));
                }
            }));
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            esperarNuevoUsuario = false; // Detener la espera de nuevos usuarios

            // Cerrar todas las conexiones existentes
            foreach (var cliente in clientes)
            {
                if (cliente != null && cliente.Connected)
                {
                    cliente.Close();
                }
            }

            // Limpiar la lista de clientes
            clientes.Clear();

            this.Invoke(new Action(() =>
            {
                ActualizarComboBoxUsuarios();
            }));
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtConversacion.Text = string.Empty;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            btParar_Click(sender, e);
            this.Close();
        } 
    }
}
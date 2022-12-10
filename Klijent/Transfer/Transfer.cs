using Podaci.Transfer;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Klijent.Transfer
{
    public class Transfer
    {
        public Socket socket;
        NetworkStream stream;
        BinaryFormatter formatter = new BinaryFormatter();

        private static Transfer instance;
        private Transfer()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("localhost", 9090);
                stream = new NetworkStream(socket);
            }
            catch (SocketException)
            {

            }
        }

        public static Transfer Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new Transfer();

                }
                return instance;
            }
        }

        public Odgovor PosaljiZahtev(SistemskaOperacija sistemskaOperacija, object objekat)
        {
            try
            {
                formatter.Serialize(stream, new Zahtev(sistemskaOperacija, objekat));
                return (Odgovor)formatter.Deserialize(stream);
            }
            catch (SocketException)
            {
                socket.Close();
                Environment.Exit(0);
                return new Odgovor(false, "");
            }
            catch (Exception)
            {
                socket.Close();
                MessageBox.Show("Server nije pokrenut.");
                Environment.Exit(0);
                return new Odgovor(false, "");
            }
        }
    }
}

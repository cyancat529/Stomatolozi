using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ServerPokretanje
    {
        Socket _socket;
        List<Socket> korisniciSoketi = new List<Socket>();

        private static ServerPokretanje _instance;
        private ServerPokretanje()
        {

        }
        public static ServerPokretanje Instance
        {
            get
            {
                if (_instance is null) _instance = new ServerPokretanje();
                return _instance;
            }
        }

        public bool Startuj()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint parametri = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
                _socket.Bind(parametri);
                _socket.Listen(5);
                korisniciSoketi.Add(_socket);
                Thread osluskuj = new Thread(OsluskivanjeMreze);
                osluskuj.Start();
                return true;
            }
            catch (SocketException)
            {
                _socket.Close();
                return false;
            }
            catch (IOException)
            {
                _socket.Close();
                return false;
            }
        }

        public bool Zaustavi()
        {
            try
            {
                foreach (Socket soket in korisniciSoketi)
                {
                    soket.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void OsluskivanjeMreze()
        {
            bool signal = false;
            while (!signal)
            {
                try
                {
                    Socket socketKlijent = _socket.Accept();
                    korisniciSoketi.Add(socketKlijent);
                    ObradaZahteva obradi = new ObradaZahteva(socketKlijent);
                    new Thread(obradi.Obradi).Start();
                }
                catch (SocketException)
                {
                    signal = true;
                }
                catch (IOException)
                {
                    signal = true;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using AplikacionaLogika;
using Podaci.Transfer;

namespace Server
{
    public class ObradaZahteva
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        NetworkStream stream;
        Socket socket;
        public ObradaZahteva(Socket socket)
        {
            this.socket = socket;
            this.stream = new NetworkStream(socket);
        }
        public void Obradi()
        {
            bool signal = false;
            while (!signal)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)binaryFormatter.Deserialize(stream);
                    Odgovor o = Obradi(zahtev);
                    binaryFormatter.Serialize(stream, o);
                }
                catch (SocketException)
                {
                    socket.Close();
                    signal = true;
                }
                catch (IOException)
                {
                    socket.Close();
                    signal = true;
                }
                catch (SerializationException)
                {
                    socket.Close();
                    signal = true;
                }
            }

        }

        private Odgovor Obradi(Zahtev zahtev)
        {
            try
            {
                switch (zahtev.SistemskaOperacija)
                {
                    case SistemskaOperacija.RegistrujNovogPacijenta: return Kontroler.Instance.RegistrujNovogPacijenta(zahtev);
                    case SistemskaOperacija.PrijaviPacijenta: return Kontroler.Instance.PrijaviPacijenta(zahtev);
                    case SistemskaOperacija.NadjiStomatologa: return Kontroler.Instance.NadjiStomatologa(zahtev);
                    case SistemskaOperacija.UcitajStomatologa: return Kontroler.Instance.UcitajStomatologa(zahtev);
                    case SistemskaOperacija.NadjiSlobodneTermine: return Kontroler.Instance.NadjiSlobodneTermine(zahtev);
                    case SistemskaOperacija.UcitajSlobodanTermin: return Kontroler.Instance.UcitajSlobodanTermin(zahtev);
                    case SistemskaOperacija.ZapamtiTermin: return Kontroler.Instance.ZapamtiTermin(zahtev);
                    case SistemskaOperacija.UcitajListuTermina: return Kontroler.Instance.UcitajListuTermina(zahtev);
                    case SistemskaOperacija.UcitajListuGradova: return Kontroler.Instance.UcitajListuGradova(zahtev);
                    case SistemskaOperacija.UcitajListuPacijenata: return Kontroler.Instance.UcitajListuPacijenata(zahtev);
                    case SistemskaOperacija.VratiTerminePoKriterijumu: return Kontroler.Instance.VratiTerminePoKriterijumu(zahtev);
                    case SistemskaOperacija.ObrisiTermin: return Kontroler.Instance.ObrisiTermin(zahtev);
                    case SistemskaOperacija.ObrisiDijagnozu: return Kontroler.Instance.ObrisiDijagnozu(zahtev);
                    case SistemskaOperacija.SacuvajSlobodneTermine: return Kontroler.Instance.SacuvajSlobodneTermine(zahtev);
                    case SistemskaOperacija.SacuvajNovogStomatologa: return Kontroler.Instance.SacuvajNovogStomatologa(zahtev);
                    case SistemskaOperacija.KartonPacijenta: return Kontroler.Instance.KartonPacijenta(zahtev);
                    case SistemskaOperacija.UcitajKartonPacijenta: return Kontroler.Instance.UcitajKartonPacijenta(zahtev);
                    case SistemskaOperacija.UcitajListuStomatologa: return Kontroler.Instance.UcitajListuStomatologa(zahtev);
                    case SistemskaOperacija.SacuvajNoviRacun: return Kontroler.Instance.UcitajListuTermina(zahtev);
                    case SistemskaOperacija.SacuvajNovuUslugu: return Kontroler.Instance.UcitajSlobodanTermin(zahtev);

                    default: return new Odgovor(false, null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Odgovor(false, null);
            }
        }
    }
}

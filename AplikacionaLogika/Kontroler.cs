using AplikacionaLogika.SistemskeOperacije;
using Podaci.Domen;
using Podaci.Transfer;
using System.Collections.Generic;

namespace AplikacionaLogika
{
    public class Kontroler
    {
        private static Kontroler instance;

        private Kontroler()
        {

        }

        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }

        public Odgovor RegistrujNovogPacijenta(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new RegistrujNovogPacijenta();
            o.execute((Pacijent) zahtev.Podaci);
            return new Odgovor(true, (Pacijent) zahtev.Podaci);
        }

        public Odgovor PrijaviPacijenta(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new PrijaviPacijenta();
            o.execute((LoginPodaci)zahtev.Podaci);
            return new Odgovor(true, ((PrijaviPacijenta)o).Objekat);
        }

        public Odgovor NadjiStomatologa(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new NadjiStomatologa();
            o.execute((KriterijumPretrage)zahtev.Podaci);
            return new Odgovor(true, ((NadjiStomatologa)o).Elementi);
        }

        public Odgovor UcitajStomatologa(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajStomatologa();
            o.execute((Stomatolog)zahtev.Podaci);
            return new Odgovor(true, ((UcitajStomatologa)o).Stomatolog);
        }

        public Odgovor NadjiSlobodneTermine(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new NadjiSlobodneTermine();
            o.execute((KriterijumPretrage)zahtev.Podaci);
            return new Odgovor(true, ((NadjiSlobodneTermine)o).Elementi);
        }

        public Odgovor UcitajSlobodanTermin(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajSlobodanTermin();
            o.execute((Termin)zahtev.Podaci);
            return new Odgovor(true, ((UcitajSlobodanTermin)o).Termin);
        }

        public Odgovor ZapamtiTermin(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new ZapamtiTermin();
            o.execute((Termin)zahtev.Podaci);
            return new Odgovor(true, "");
        }

        public Odgovor UcitajListuTermina(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajListuTermina();
            o.execute(null);
            return new Odgovor(true, ((UcitajListuTermina)o).Elementi);
        }

        public Odgovor VratiTerminePoKriterijumu(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new VratiTerminePoKriterijumu();
            o.execute((KriterijumPretrage)zahtev.Podaci);
            return new Odgovor(true, ((VratiTerminePoKriterijumu)o).Elementi);
        }

        public Odgovor ObrisiTermin(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new ObrisiTermin();
            o.execute((Termin)zahtev.Podaci);
            return new Odgovor(true, "");
        }

        public Odgovor ObrisiDijagnozu(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new ObrisiDijagnozu();
            o.execute((Dijagnoza)zahtev.Podaci);
            return new Odgovor(true, "");
        }

        public Odgovor SacuvajSlobodneTermine(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new SacuvajSlobodneTermine((List<Termin>) zahtev.Podaci);
            o.execute(null);
            return new Odgovor(true, "");
        }

        public Odgovor SacuvajNovogStomatologa(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new SacuvajNovogStomatologa();
            o.execute((Stomatolog)zahtev.Podaci);
            return new Odgovor(true, "");
        }

        public Odgovor SacuvajNoviRacun(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new SacuvajNoviRacun();
            o.execute((Racun)zahtev.Podaci);
            return new Odgovor(true, "");
        }

        public Odgovor SacuvajNovuUslugu(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new SacuvajNovuUslugu();
            o.execute((Usluge)zahtev.Podaci);
            return new Odgovor(true, "");
        }

        public Odgovor UcitajListuGradova(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajListuGradova();
            o.execute(null);
            return new Odgovor(true, ((UcitajListuGradova)o).Elementi);
        }

        public Odgovor UcitajListuPacijenata(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajListuPacijenata();
            o.execute(null);
            return new Odgovor(true, ((UcitajListuPacijenata) o).Elementi );
        }

        public Odgovor KartonPacijenta(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new KartonPacijenta((List<Dijagnoza>) zahtev.Podaci);
            o.execute(null);
            return new Odgovor(true, "");
        }

        public Odgovor UcitajKartonPacijenta(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajKartonPacijenta();
            o.execute((KriterijumPretrage)zahtev.Podaci);
            return new Odgovor(true, ((UcitajKartonPacijenta)o).Elementi);
        }

        public Odgovor UcitajListuStomatologa(Zahtev zahtev)
        {
            OpstaSistemskaOperacija o = new UcitajListuStomatologa();
            o.execute(null);
            return new Odgovor(true, ((UcitajListuStomatologa)o).Elementi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Transfer
{
    [Serializable]
    public enum SistemskaOperacija
    {
        RegistrujNovogPacijenta,
        PrijaviPacijenta,
        NadjiStomatologa,
        UcitajStomatologa, 
        NadjiSlobodneTermine, 
        UcitajSlobodanTermin, 
        ZapamtiTermin, 
        UcitajListuTermina, 
        NadjiTermine, 
        UcitajTermin, 
        VratiTerminePoKriterijumu, 
        ObrisiTermin,
        ObrisiDijagnozu,
        SacuvajSlobodneTermine, 
        SacuvajNovogStomatologa,
        SacuvajNoviRacun,
        SacuvajNovuUslugu,
        UcitajListuGradova,
        UcitajListuPacijenata, 
        KartonPacijenta,
        UcitajKartonPacijenta,
        UcitajListuStomatologa

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_eksamen
{
    class FuncLayer : INotifyPropertyChanged
    {
        public Model Data { get; set; } = new Model();
        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                PropertyChangedEventArgs(propName));
            }
        }


        public void OpretKunde(string kundeNavn, int KundeAdresse, int kundeTelefon)
        {
            Kunde kunde;
            vare = new Vare();
            vare.Navn = navn;
            vare.Pris = pris;
            vare.Indkøbspris = indkøbspris;
            vare.Beskrivelse = beskrivelse;
            Data.OpretVare(vare);
            RaisePropertyChanged(nameof(Vareoversigt));
        }
    }
}

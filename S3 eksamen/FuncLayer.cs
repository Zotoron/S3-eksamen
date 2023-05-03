using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static S3_eksamen.Model;

namespace S3_eksamen
{
    public class FuncLayer : INotifyPropertyChanged
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


        public void OpretBog(string Forfatter, string Titel, string Udgiver, int Eksemplarer, int ISBN)
        {
            Bog bog;
            bog = new Bog();
            bog.Forfatter = forfatter;
            bog.Titel = titel;
            bog.Udgiver = udgiver;
            vare.Beskrivelse = beskrivelse;
            Data.OpretVare(vare);
            RaisePropertyChanged(nameof(Vareoversigt));
        }
    }
}

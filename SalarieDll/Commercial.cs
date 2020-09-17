using System;
using System.Collections.Generic;
using System.Text;


namespace SalarieDll
{
    public class Commercial : Salarie
    {
        double _chiffreDAffaire;
        double _commission;
        public Commercial()
        {

        }
        public Commercial(double ca, double com,String Matricule, string Nom, String Prenom, double SalaireBrut, double TauxCS) : base(Matricule,Nom,Prenom, SalaireBrut, TauxCS)
        {
            _chiffreDAffaire = ca;
            _commission = com;
        }
        public double ChiffreDAffaire
        {
            get { return _chiffreDAffaire; }
            set { _chiffreDAffaire = value; }
        }
        public double Commission
        {
            get { return _commission; }
            set { _commission = value; }
        }
       
       public override double CalculerSalaireNet()
        {
            return base.CalculerSalaireNet() + base.CalculerSalaireNet()*_commission;
        }
        public override string ToString()
        {
            return string.Format(base.ToString() + "{0}0%;{1}", Commission, ChiffreDAffaire);
        }


    }
}

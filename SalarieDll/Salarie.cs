using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SalarieDll;
namespace SalarieDll
{
   public class Salarie
    {   //constructeur par defaut
        static int _compteur;
        public static int Compteur
        {
            get{ return _compteur; }
        }
        public Salarie()
        {
            _compteur++;
        }
        ~Salarie()
        {
            _compteur--;
        }
        
        
        //constructeur de recopie
       
        //constructeur d initialisation des propietes nom, prenom et matricule
        public Salarie(String Matricule, string Nom, String Prenom, double SalaireBrut, double TauxCS) :this()
        {
            this.Matricule = Matricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.SalaireBrut = SalaireBrut;
            this.TauxCS = TauxCS;
          
        }
        public Salarie(Salarie salarie) : this(salarie.Matricule, salarie.Nom, salarie.Prenom,salarie.TauxCS,salarie.SalaireBrut)
        {
            //this.Matricule = salarie.Matricule;
            //this.Nom = salarie.Nom;
            //this.Prenom = salarie.Prenom;
            //this.DateDeNaissance = salarie.DateDeNaissance;
           // this.SalaireBrut = salarie.SalaireBrut;
            //this.TauxCS = salarie.TauxCS;
            this.DateDeNaissance = salarie.DateDeNaissance;
        }
        public override bool Equals(Object sala)
        {
            Salarie sa = sala as Salarie;
            if (sa==null)
            {
                return false;
            }
            if (this._matricule == sa._matricule)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public virtual int GetHashCode(Object sal1)
        {
            return sal1.GetHashCode();
               
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2}", this._nom, this._prenom, this._matricule);
        }



        string _matricule;
        public string Matricule
        {
            get { return _matricule; }
            set
            {
                if (MatriculeVerif(value)==false)
                {
                    throw new ApplicationException("erreur");
                }
                _matricule = value; }
        }

        string _nom;
        public string Nom
        {
            get { return _nom; }
            set {
                if (NomVerif(value) ==false)
                {
                    throw new Exception("erreur");
                }
                   _nom = value; }
        }
        string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (PrenomVerif(value) ==false)
                {
                    throw new Exception("erreur");
                } _prenom = value; }
        }

        double _salaireBrut;
        public double SalaireBrut
        {
            get { return _salaireBrut; }
            set { _salaireBrut = value; }
        }
        double _tauxCS;
        public double TauxCS
        {
            get { return _tauxCS; }
            set
            {
                if (TauxVerif(value)==false)
                {
                    throw new Exception("Entrez un taux entre 0 et 0.6");
                }
                _tauxCS = value;
            }
        }
        public virtual double CalculerSalaireNet()  
        {
          
                if (TauxVerif(_tauxCS)==false)
                {
                    throw new Exception("erreur");
    }
                else
                 {
                    return (_salaireBrut-(_salaireBrut * _tauxCS));
}
        }

        
        DateTime _dateDeNaissance;
        DateTime DateDeNaissance
        {
            get
            {
                
                return _dateDeNaissance;
            }
            set
            {
                if (DateNaissanceVerif(value) == false)
                {
                    throw new Exception(string.Format("Vous etes trop jeune ou beaucoup trop vieux"));

                }
                _dateDeNaissance = value;
            }
        }
        public static bool MatriculeVerif(string _matricule)
        {
            int longueur = _matricule.Length;
            if (String.IsNullOrEmpty(_matricule) || longueur != 7)
            {
                return false;
            }
            for (int i = 0; i < longueur; i++)
            {
                if (i >= 2 && i <= 4)
                {
                    if (!char.IsLetter(_matricule[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if ((!char.IsDigit(_matricule[i])))
                    {
                        return false;
                    }

                }
                
            }
            return true;
        }
         

        public static bool NomVerif(string _nom)
        {
            if (string.IsNullOrEmpty(_nom))
            {
                return false;
            }
          
            if (_nom.Length < 3 || _nom.Length > 30)
            {
                return false;
            }
            for (int i = 0; i < _nom.Length; i++)
            {
                if (char.IsDigit(_nom[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool PrenomVerif(string _prenom)
        {
                if (string.IsNullOrEmpty(_prenom))
                {
                    return false;
                }
           
            if (_prenom.Length < 3 || _prenom.Length > 30)
                {
                    return false;
                }


            for (int i = 0; i < _prenom.Length; i++)
                {
                    if (char.IsDigit(_prenom[i]))
                    {
                        return false;
                    }
                }
            return true;
        }
        public static bool TauxVerif(double _tauxCS)
        {
            if (_tauxCS>=0 && _tauxCS <= 0.6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DateNaissanceVerif(DateTime _dateDeNaissance)
        { 
        DateTime Anneelimite1900 = new DateTime(1900, 1, 1);
            if (_dateDeNaissance< Anneelimite1900)
            {
                return false;
            }
           
            DateTime Anneelimite15A = DateTime.Now.AddYears(-15);


            if (_dateDeNaissance> Anneelimite15A)
                {
                return false;
                }
            return true;
   

        }

    }
   
}


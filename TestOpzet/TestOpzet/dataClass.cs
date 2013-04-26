using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestOpzet
{
    public partial class dataClass
    {
        #region Constructors
        private string opldomcode;
        private string doscode;
        private string nakwados;
        private string crebcokwali;
        private string naamkwali;
        private string kdversie;
        private string opleivari;
        private string niveau;
        private string leerweg;
        private string kenncentr;
        private string startdeeln;
        private string examprof;
        private string manager;
        private string portehoud;
        private string exmnplanco;
        private string kt1;
        private string ktnm1;
        private string wp1;
        private string kt2;
        private string ktnm2;
        private string wp2;
        private string kt3;
        private string ktnm3;
        private string wp3;
        private string kt4;
        private string ktnm4;
        private string wp4;
        private string kt5;
        private string ktnm5;
        private string wp5;
        private string kt6;
        private string ktnm6;
        private string wp6;
        #endregion

        public dataClass()
        { 
            
        }

        #region dataClass Overloaded
        public dataClass(string opldomcode, string doscode, string nakwados, string crebcokwali, string naamkwali, string kdversie,
                            string opleivari, string niveau, string leerweg , string kenncentr, string startdeeln, string examprof , string manager,
                                string portehoud, string exmnplanco , string kt1, string ktnm1, string wp1, string kt2, string ktnm2, string wp2,
                                    string kt3, string ktnm3, string wp3, string kt4, string ktnm4, string wp4, string kt5, string ktnm5, string wp5,
                                        string kt6, string ktnm6, string wp6)
        
        {
          this.opldomcode = opldomcode;
          this.doscode = doscode;
          this.nakwados = nakwados;
          this.crebcokwali = crebcokwali;
          this.naamkwali = naamkwali;
          this.kdversie = kdversie;
          this.opleivari = opleivari;
          this.niveau = niveau;
          this.leerweg = leerweg;
          this.kenncentr = kenncentr;
          this.startdeeln = startdeeln;
          this.examprof = examprof;
          this.manager = manager;
          this.portehoud = portehoud;
          this.exmnplanco = exmnplanco;
          this.kt1 = kt1;
          this.ktnm1 = ktnm1;
          this.wp1 = wp1;
          this.kt2 = kt2;
          this.ktnm2 = ktnm2;
          this.wp2 = wp2;
          this.kt3 = kt3;
          this.ktnm3 = ktnm3;
          this.wp3 = wp3;
          this.kt4 = kt4;
          this.ktnm4 = ktnm4;
          this.wp4 = wp4;
          this.kt5 = kt5;
          this.ktnm5 = ktnm5;
          this.wp5 = wp5;
          this.kt6 = kt6;
          this.ktnm6 = ktnm6;
          this.wp6 = wp6;
        }
        #endregion

        #region Properties 
        public string Opldomcode
        {
            get { return this.opldomcode; }
            set { this.opldomcode = value; }
        }
        
        public string Doscode
        {
            get { return this.doscode; }
            set { this.doscode = value; }
        }
        public string Nakwados
        {
            get { return this.nakwados; }
            set { this.nakwados = value; }
        }
        public string Crebcokwali
        {
            get { return this.crebcokwali; }
            set { this.crebcokwali = value; }
        }
        public string Naamkwali
        {
            get { return this.naamkwali; }
            set { this.naamkwali = value; }
        }
        public string Kdversie
        {
            get { return this.kdversie; }
            set { this.kdversie = value; }
        }
        public string Opleivari
        {
            get { return this.opleivari; }
            set { this.opleivari = value; }
        }
        public string Niveau
        {
            get { return this.niveau; }
            set { this.niveau = value; }
        }
        public string Leerweg
        {
            get { return this.leerweg; }
            set { this.leerweg = value;}
        }
        public string Kenncentr
        {
            get { return this.kenncentr; }
            set { this.kenncentr = value; }
        }
        public string Startdeeln
        {
            get { return this.startdeeln; }
            set { this.startdeeln = value; }
        }
        public string Examprof
        {
            get { return this.examprof; }
            set { this.examprof = value; }
        }
        public string Manager
        {
            get { return this.manager; }
            set { this.manager = value; }
        }
        public string Portehoud
        {
            get { return this.portehoud; }
            set { this.portehoud = value; }
        }
        public string Exmnplanco
        {
            get { return this.exmnplanco; }
            set { this.exmnplanco = value; }
        }
        public string Kt1
        {
            get { return this.kt1; }
            set { this.kt1 = value; }
        }
        public string Ktnm1
        {
            get { return this.ktnm1; }
            set { this.ktnm1 = value; }
        }
        public string Wp1
        {
            get { return this.wp1; }
            set { this.wp1 = value; }
        }
        public string Kt2
        {
            get { return this.kt2; }
            set { this.kt2 = value; }
        }
        public string Ktnm2
        {
            get { return this.ktnm2; }
            set { this.ktnm2 = value; }
        }
        public string Wp2
        {
            get { return this.wp2; }
            set { this.wp2 = value; }
        }
        public string Kt3
        {
            get { return this.kt3; }
            set { this.kt3 = value; }
        }
        public string Ktnm3
        {
            get { return this.ktnm3; }
            set { this.ktnm3 = value; }
        }
        public string Wp3
        {
            get { return this.wp4; }
            set { this.wp4 = value; }
        }
        public string Kt4
        {
            get { return this.kt4; }
            set { this.kt4 = value; }
        }
        public string Ktnm4
        {
            get { return this.ktnm4; }
            set { this.ktnm4 = value; }
        }
        public string Wp4
        {
            get { return this.wp4; }
            set { this.wp4 = value; }
        }
        public string Kt5
        {
            get { return this.kt5; }
            set { this.kt5 = value; }
        }
        public string Ktnm5
        {
            get { return this.ktnm5; }
            set { this.ktnm5 = value; }
        }
        public string Wp5
        {
            get { return this.wp5; }
            set { this.wp5 = value; }
        }
        public string Kt6
        {
            get { return this.kt6; }
            set { this.kt6 = value; }
        }
        public string Ktnm6
        {
            get { return this.ktnm6; }
            set { this.ktnm6 = value; }
        }
        public string Wp6
        {
            get { return this.wp6; }
            set { this.wp6 = value; }
        }
        #endregion
        

    }
}

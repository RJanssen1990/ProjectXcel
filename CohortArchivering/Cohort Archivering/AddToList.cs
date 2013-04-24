using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cohort_Archivering
{
    public class AddToList
    {
        public ExamenPlanList examenPlanlist = new ExamenPlanList();
        /// <summary>
        /// Haalt de properties op en stopt deze in de lijst examenplanlist
        /// </summary>
        /// <param name="creboCode"></param>
        /// <param name="opleidingsnaam"></param>
        /// <param name="kwalificatie"></param>
        /// <param name="uitstroom"></param>
        /// <param name="niveau"></param>
        /// <param name="leerroute"></param>
        /// <param name="kenniscentrum"></param>
        /// <param name="cohort"></param>
        /// <param name="kdVersie"></param>
        /// <param name="leerlingaantal"></param>
        /// <param name="examenProfiel"></param>
        /// <param name="voorzitter"></param>
        /// <param name="aanspreekpunt"></param>
        /// <param name="manager"></param>
        /// <param name="examen"></param>
        /// <param name="kerntaken"></param>
        /// <param name="werkProces"></param>
        /// <param name="periodeAfname"></param>
        /// <param name="naamOpdracht"></param>
        /// <param name="statusOpdracht"></param>
        public void fillExamenlist(int creboCode, string opleidingsnaam, string kwalificatie, string uitstroom,
                                    int niveau, string leerroute, string kenniscentrum, int cohort, int kdVersie,
                                       int leerlingaantal, string examenProfiel, string voorzitter, string aanspreekpunt,
                                          string manager, string examen, string kerntaken, string werkProces, string periodeAfname,
                                              string naamOpdracht, string statusOpdracht, string examen2, string kerntaken2, 
                                              string periodeAfname2, string werkProces2, string naamOpdr2, string statusOpdr2,
                                                string examen3, string kerntaken3,
                                              string periodeAfname3, string werkProces3, string naamOpdr3, string statusOpdr3,
                                                string examen4, string kerntaken4,
                                              string periodeAfname4, string werkProces4, string naamOpdr4, string statusOpdr4,
                                                string examen5, string kerntaken5,
                                              string periodeAfname5, string werkProces5, string naamOpdr5, string statusOpdr5,
                                                string examen6, string kerntaken6,
                                              string periodeAfname6, string werkProces6, string naamOpdr6, string statusOpdr6)
        {
            ExamenPlan examenPlan = new ExamenPlan();
            examenPlan.CreboCode = creboCode;
            examenPlan.Opleidingsnaam = opleidingsnaam;
            examenPlan.Kwalificatie = kwalificatie;
            examenPlan.Uitstroom = uitstroom;
            examenPlan.Niveau = niveau;
            examenPlan.LeerRoute = leerroute;
            examenPlan.KennisCentrum = kenniscentrum;
            examenPlan.Cohort = cohort;
            examenPlan.KdVersie = kdVersie;
            examenPlan.AantalLeerlingen = leerlingaantal;
            examenPlan.ExamenProfiel = examenProfiel;
            examenPlan.TeamVoorzitter = voorzitter;
            examenPlan.AanspreekPunt = aanspreekpunt;
            examenPlan.Manager = manager;
            
            examenPlan.Examen = examen;
            examenPlan.Kerntaken = kerntaken;
            examenPlan.WerkProcessen = werkProces;
            examenPlan.PeriodeAfnamen = periodeAfname;
            examenPlan.NaamOpdracht = naamOpdracht;
            examenPlan.StatusOpdracht = statusOpdracht;

            examenPlan.Examen2 = examen2;
            examenPlan.KernTaken2 = kerntaken2;
            examenPlan.WerkProcessen2 = werkProces2;
            examenPlan.PeriodeAfnamen2 = periodeAfname2;
            examenPlan.NaamOpdracht2 = naamOpdr2;
            examenPlan.StatusOpdracht2 = statusOpdr2;

            examenPlan.Examen3 = examen3;
            examenPlan.KernTaken3 = kerntaken3;
            examenPlan.WerkProcessen3 = werkProces3;
            examenPlan.PeriodeAfnamen3 = periodeAfname3;
            examenPlan.NaamOpdracht3 = naamOpdr3;
            examenPlan.StatusOpdracht3 = statusOpdr3;

            examenPlan.Examen4 = examen4;
            examenPlan.KernTaken4 = kerntaken4;
            examenPlan.WerkProcessen4 = werkProces4;
            examenPlan.PeriodeAfnamen4 = periodeAfname4;
            examenPlan.NaamOpdracht4 = naamOpdr4;
            examenPlan.StatusOpdracht4 = statusOpdr4;

            examenPlan.Examen5 = examen5;
            examenPlan.KernTaken5 = kerntaken5;
            examenPlan.WerkProcessen5 = werkProces5;
            examenPlan.PeriodeAfnamen5 = periodeAfname5;
            examenPlan.NaamOpdracht5 = naamOpdr5;
            examenPlan.StatusOpdracht5 = statusOpdr5;

            examenPlan.Examen6 = examen6;
            examenPlan.KernTaken6 = kerntaken6;
            examenPlan.WerkProcessen6 = werkProces6;
            examenPlan.PeriodeAfnamen6 = periodeAfname6;
            examenPlan.NaamOpdracht6 = naamOpdr6;
            examenPlan.StatusOpdracht6 = statusOpdr6;

            examenPlanlist.Add(examenPlan);
        }
        public ExamenPlanList GetExamenPlanList()
        {
            if (this.examenPlanlist != null)
                return this.examenPlanlist;
            else
            {
                MessageBox.Show("Lijst is leeg.");
                return null;
            }
        }
    }
}

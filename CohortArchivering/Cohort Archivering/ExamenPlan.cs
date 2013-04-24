using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cohort_Archivering
{
    /// <summary>
    /// Het examenplan, de properties komen overeen met de velden in de mainform
    /// </summary>
    public class ExamenPlan
    {
        //alle elementen die een examenplan bevatten
        public ExamenPlan()
        {

        }

        //De crebocode van de uitstroom zoals vermeld in het kwalificatiedossier van 2012-2013
        /// <summary>
        /// Property voor de crebocode
        /// </summary>
        public int CreboCode
        {
            get;
            set;
        }

        //De officiële naam naam van de opleiding zoals beschreven in het kwalificatiedossier van 2012-2013
        public string Opleidingsnaam
        {
            get;
            set;
        }

        //De officiële benaming van het kwalificatiedossier 2012-2013
        public string Kwalificatie
        {
            get;
            set;
        }

        //De officiële benaming van van de uitstroom (kan hetzelfde zijn als kwalificatie maar kan ook afwijken)
        public string Uitstroom
        {
            get;
            set;
        }

        //Het niveau van de gevolgde opleiding
        public int Niveau
        {
            get;
            set;
        }

        //De leerroute (bijv BOL of BBl)
        public string LeerRoute
        {
            get;
            set;
        }

        //De kenniscentra's voor het beroepsonderwijs en bedrijfsleven. In 2012 zijn er totaal 17
        public string KennisCentrum
        {
            get;
            set;
        }

        //Start wanneer de student is begonnen met school(let op met afstroom (string))
        //gekozen voor een int omdat het alleen het jaartal is
        public int Cohort
        {
            get;
            set;
        }

        // Kwalificatie dossier versie
        public int KdVersie
        {
            get;
            set;
        }

        //Aantal leerlingen die in een bepaald cohort zijn binnen gekomen
        public int AantalLeerlingen
        {
            get;
            set;
        }

        //??
        public string ExamenProfiel
        {
            get;
            set;
        }
        
        // Onderwijs en examen regelement
        /*public string ExamenPlanOER
        {
            get;
            set;
        }*/

        //Degene die het team als aanspreekpunt heeft gekozen
        public string TeamVoorzitter
        {
            get;
            set;
        }

        //Degene die de examens organiseert voor dat cohort
        public string AanspreekPunt
        {
            get;
            set;
        }

        // Opleidings manager
        public string Manager
        {
            get;
            set;
        }

        //verschillende exames, moeten er meer dan 1 kunnen zijn
        public string Examen
        {
            get;
            set;
        }

        //verschillende kerntaken dit moeten er meer dan 1 zijn
        public string Kerntaken
        {
            get;
            set;
        }

        //Werkprocessen van kerntaken dit moeten er meer dan 1 zijn
        public string WerkProcessen
        {
            get;
            set;
        }


        //Periode van de afname van de exame opdracht(vragen p in labeltje)
        public string PeriodeAfnamen
        {
            get;
            set;
        }

        //de naam va de opdracht
        public string NaamOpdracht
        {
            get;
            set;
        }

        //de status van de opdracht(dropdown combobox)
        public string StatusOpdracht
        {
            get;
            set;
        }

        public string Examen2 { get; set; }
        public string KernTaken2 { get; set; }
        public string WerkProcessen2 { get; set; }
        public string PeriodeAfnamen2 { get; set; }
        public string NaamOpdracht2 { get; set; }
        public string StatusOpdracht2 { get; set; }

        public string Examen3 { get; set; }
        public string KernTaken3 { get; set; }
        public string WerkProcessen3 { get; set; }
        public string PeriodeAfnamen3 { get; set; }
        public string NaamOpdracht3 { get; set; }
        public string StatusOpdracht3 { get; set; }

        public string Examen4 { get; set; }
        public string KernTaken4 { get; set; }
        public string WerkProcessen4 { get; set; }
        public string PeriodeAfnamen4 { get; set; }
        public string NaamOpdracht4 { get; set; }
        public string StatusOpdracht4 { get; set; }

        public string Examen5 { get; set; }
        public string KernTaken5 { get; set; }
        public string WerkProcessen5 { get; set; }
        public string PeriodeAfnamen5 { get; set; }
        public string NaamOpdracht5 { get; set; }
        public string StatusOpdracht5 { get; set; }

        public string Examen6 { get; set; }
        public string KernTaken6 { get; set; }
        public string WerkProcessen6 { get; set; }
        public string PeriodeAfnamen6 { get; set; }
        public string NaamOpdracht6 { get; set; }
        public string StatusOpdracht6 { get; set; }
    }
}

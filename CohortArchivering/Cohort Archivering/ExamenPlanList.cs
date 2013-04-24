using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Cohort_Archivering
{
    /// <summary>
    /// Lijst van examenplannen, deze maakt gebruik van een collectionbase
    /// </summary>
    public class ExamenPlanList : CollectionBase
    {

        public ExamenPlanList()
        {
   
        }
        /// <summary>
        /// Hier word de examenplan toegevoegd aan de lijst
        /// </summary>
        /// <param name="examenplan"></param>
        public void Add(ExamenPlan examenplan)
        {
            List.Add(examenplan);
        }

    }
}

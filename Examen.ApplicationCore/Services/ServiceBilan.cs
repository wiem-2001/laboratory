using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.ApplicationCore.Services
{
    public class ServiceBilan : IServiceBilan
    {
        public double totalPriceBilan(Bilan bilan)
        {
            var countAnalyse = bilan.Analyses.Count();
            var total = bilan.Analyses.Sum(a => a.prixAnalyse);
            if (countAnalyse > 5)
            {
                return total*0.9;
            }
            else return total;
        }
        public DateTime GetDateRecuperation(Bilan bilan)
        {
            IEnumerable<Analyse> analyses = bilan.Analyses;
            int maxDuree = analyses.Max(a => a.dureeResultat);
            DateTime dateprelevementBilan = bilan.DatePrelevement.AddHours(maxDuree);
            return dateprelevementBilan;
        }
    }
}

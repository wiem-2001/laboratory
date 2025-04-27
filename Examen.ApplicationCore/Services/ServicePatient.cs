using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.ApplicationCore.Services
{
    public class ServicePatient : IServicePatient
    {
        public IEnumerable<IGrouping<Bilan, Analyse>> getAnalyseByCurrentYear(Patient patient)
        {
            IEnumerable<Bilan> bilans = patient.Bilans;

            IEnumerable<Analyse> analyses = from b in bilans
                                            where b.DatePrelevement.Year == DateTime.Now.Year
                                            from a in b.Analyses
                                            select a;

            var req = from a in analyses
                      where a.valeurAnalysee > a.valeurMaxNormale || a.valeurAnalysee < a.valeurMinNormale
                      group a by a.Bilan;

            return req;
        }

       
    }
}

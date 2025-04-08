using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Analyse
    {
        public int analyseId { get; set; }
        public int dureeResultat { get; set; }
        public double prixAnalyse { get; set; }
        public string TypeAnalyse { get; set; }
        public float valeurAnalysee { get; set; }
        public float valeurMaxNormale { get; set; }
        public float valeurMinNormale { get; set; }
        public int CodeInfirmier { get; set; }
        public int CodePatient { get; set; }
        public DateTime DatePrelevement { get; set; }

        public Bilan Bilan { get; set; }
    }
}

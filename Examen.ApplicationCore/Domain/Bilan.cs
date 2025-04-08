using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Bilan
    {
        public DateTime DatePrelevement { get; set; }
        public string EmailMedecin { get; set; }
        public bool Paye { get; set; }
        public int CodeInfirmier { get; set; }
        public int CodePatient { get; set; }
        public Infirmier Infirmier { get; set; }
        public Patient Patient { get; set; }
        public List<Analyse> Analyses { get; set; }
    }
}

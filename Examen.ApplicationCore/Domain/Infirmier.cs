using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum Specilite
    {
        Hematologie ,
        Biochimie,
        Autre
    }
    public  class Infirmier
    {
        public int InfirmierId { get; set; }
        public string NomComplet { get; set; }
        public Specilite Specilite { get; set; }
        public List<Bilan> Bilans { get; set; }
    }
}

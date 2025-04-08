using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Patient
    {
        [MaxLength(5, ErrorMessage = "maximum 5 caracteres")]
        [Key]
        public int codePatient { get; set; }
        public string EmailPatient { get; set; }
        [Display(Name = "Informations supplémentaires")]
        [DataType(DataType.MultilineText)]
        public string Informations { get; set; }
        public string NomComplet { get; set; }
        public string NumeroTel { get; set; }
        public List<Bilan> Bilans { get; set; }

    }
}

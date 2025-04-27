using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceBilan
    {
        public double totalPriceBilan(Bilan bilan);
        public DateTime GetDateRecuperation(Bilan bilan);
    }
}

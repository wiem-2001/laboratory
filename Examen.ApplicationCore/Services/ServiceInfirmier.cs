using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.ApplicationCore.Services
{
    public class ServiceInfirmier : Service<Infirmier> ,IServiceInfirmier
    {
        public ServiceInfirmier(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PourcentageInfirmiersParSpecialite(Specilite specialite)
        {
            var infirmiers = GetMany();

            var total = infirmiers.Count();
            if (total == 0)
                return 0;

            var countSpecialite = (from i in infirmiers
                                   where i.Specilite == specialite
                                   select i).Count();

            return (double)countSpecialite / total * 100;

        }

        private object GetMany<T>()
        {
            throw new NotImplementedException();
        }
    }
}

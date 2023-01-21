using InyeccionDependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Clases
{
    internal sealed class ServiceLifetimeReporter
    {
        private readonly IScopedService _plataforma;

        public ServiceLifetimeReporter(
            IScopedService scopedService) => (_plataforma) = (scopedService);

        public void ReportServiceLifetimeDetails(string lifetimeDetails)
        {
            Console.WriteLine(lifetimeDetails);
            Console.WriteLine(_plataforma.showLifetime());
        }

        
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Interfaces
{
    internal interface ISingletonService : IReportServices
    {
        ServiceLifetime IReportServices.ServiceLifetime => ServiceLifetime.Singleton;
        string showLifetime();
    }
}

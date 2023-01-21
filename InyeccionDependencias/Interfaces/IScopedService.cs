using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Interfaces
{
    internal interface IScopedService : IReportServices
    {
        ServiceLifetime IReportServices.ServiceLifetime => ServiceLifetime.Scoped;
        string showLifetime();
    }
}

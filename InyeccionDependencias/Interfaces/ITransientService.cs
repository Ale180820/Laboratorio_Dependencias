using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Interfaces
{
    internal interface ITransientService : IReportServices
    {
        ServiceLifetime IReportServices.ServiceLifetime => ServiceLifetime.Transient;
        string showLifetime();
    }
}

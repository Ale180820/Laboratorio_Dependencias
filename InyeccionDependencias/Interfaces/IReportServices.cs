using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Interfaces
{
    public interface IReportServices
    {
        Guid ID { get; }
        ServiceLifetime ServiceLifetime { get; }
    }
}

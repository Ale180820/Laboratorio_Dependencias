using InyeccionDependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Clases
{
    internal sealed class Serie : ITransientService
    {
        Guid IReportServices.ID { get; } = Guid.NewGuid();
        public string showLifetime()
        {
            return LogService(this, "Serie");
        }
        private static string LogService<T>(T service, string message)
            where T : IReportServices => $"    {typeof(T).Name}: {service.ID} ({message})";
    }
}

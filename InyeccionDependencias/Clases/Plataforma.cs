using InyeccionDependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias.Clases
{
    internal sealed class Plataforma : IScopedService
    {
        private readonly ISingletonService _categoria;
        Guid IReportServices.ID { get; } = Guid.NewGuid();
        public Plataforma(ISingletonService categoria)
        {
            _categoria = categoria;
        }
        public string showLifetime()
        {
            Console.WriteLine(_categoria.showLifetime());
            return LogService(this, "Plataforma");
        }
        private static string LogService<T>(T service, string message)
            where T : IReportServices => $"    {typeof(T).Name}: {service.ID} ({message})";
    }
}

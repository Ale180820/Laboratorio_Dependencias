using InyeccionDependencias.Interfaces;

namespace InyeccionDependencias.Clases
{
    internal sealed class Categoria : ISingletonService
    {
        private readonly ITransientService _serie;
        Guid IReportServices.ID { get; } = Guid.NewGuid();

        public Categoria(ITransientService serie)
        {
            _serie = serie;
        }
        public string showLifetime()
        {
            Console.WriteLine(_serie.showLifetime());
            return LogService(this, "Categoría");
        }
        private static string LogService<T>(T service, string message)
            where T : IReportServices => $"    {typeof(T).Name}: {service.ID} ({message})";
    }
}

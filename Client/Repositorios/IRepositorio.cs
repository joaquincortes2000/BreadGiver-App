using System.Threading.Tasks;

namespace BreadGiverApp.Client.Repositorios
{
    interface IRepositorio
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
    }
}

using System.Threading.Tasks;
using Api.Domain.Entity;

namespace Api.Domain.Interface
{
    public interface ICorrecaoService
    {
        Task<Correcao> GetTaxa(Correcao correcao);
    }
}

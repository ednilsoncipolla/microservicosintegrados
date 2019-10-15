
using System.Threading.Tasks;
using Api.Domain.Entity;
using Api.Domain.Interface;

namespace Api.Services
{
    public class CorrecaoService : ICorrecaoService
    {
        public async Task<Correcao> GetTaxa(Correcao correcao)
        {
            correcao.Taxa = 0.01m;
            return correcao;
        }
    }
}

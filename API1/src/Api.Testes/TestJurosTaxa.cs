using System.Threading.Tasks;
using Api.Domain.Entity;
using Api.Domain.Interface;
using Api.Services;
using FluentAssertions;
using Xunit;

namespace Api.Testes
{
    public class TestJurosTaxa
    {

        [Fact]
        public void CorrecaoService_Domino_DeveImplementarICorrecaoService()
        {
        //Given

        //When
            ICorrecaoService _servico = new CorrecaoService();

        //Then
            _servico.Should().Be(_servico is ICorrecaoService,"Tipo/Interface incorreta");
        }

        [Fact]
        public void Taxa_ObterValor_DeveRetornarValorMaiorQueZero()
        {
        //Given
            Correcao _correcao = new Correcao();
            ICorrecaoService _servico = new CorrecaoService();
            Task<Correcao> _serviçoTask = _servico.GetTaxa(_correcao);

        //When
            _serviçoTask.Start();
            _serviçoTask.Wait();

        //Then
            _serviçoTask.Result.Taxa.Should().BeGreaterThan(0); 
        }


        
    }
}
using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application
{
  public interface IDomainService
  {
    Task<TResponse> ProcessAsync<TResponse, TRequest>(TRequest request, CancellationToken cancellationToken)
      where TRequest : class, new()
      where TResponse : class, new();
  }
}

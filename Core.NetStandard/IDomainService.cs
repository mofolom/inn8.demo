using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application.Core;

public interface IDomainService<TResponse, TRequest> where TRequest : class, new() where TResponse : class, new()
{
    Task<TResponse> ProcessAsync(TRequest request, CancellationToken cancellationToken);
}

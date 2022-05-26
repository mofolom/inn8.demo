using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INN8.Application.Services.Infrastructure
{
  public class Mapper : IMapper
  {
    public TDestination Map<TSource, TDestination>(TSource source)
    {
      return source.Adapt<TSource, TDestination>();
    }
  }
}

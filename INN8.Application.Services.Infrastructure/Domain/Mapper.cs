using INN8.Application.Core.Model;
using INN8.Application.Services.Domain;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INN8.Application.Services.Infrastructure.Domain
{
    public class Mapper : IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source, MappingProfile profile)
        {
            return source.Adapt<TSource, TDestination>();
        }
    }
}

using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Mars_Backend.GraphQL
{
    public class ARS_Schema : Schema
    {
        public ARS_Schema(IServiceProvider resolver) : base(resolver)
        {
            Query = (IObjectGraphType)resolver.GetService(typeof(Query));
            Mutation = (IObjectGraphType)resolver.GetService(typeof(Mutation));
        }
    }
}

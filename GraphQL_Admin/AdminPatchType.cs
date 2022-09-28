using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace Team_Mars_Backend.GraphQL_Admin
{
    public class AdminPatchType : InputObjectGraphType
    {
        public AdminPatchType()
        {
            Name = "adminPatch";
            base.Field<NonNullGraphType<StringGraphType>>("Password");
            base.Field<NonNullGraphType<LongGraphType>>("Phone_number");
            base.Field<NonNullGraphType<IntGraphType>>("Admin_Id");
            base.Field<NonNullGraphType<IntGraphType>>("email");
            base.Field<NonNullGraphType<IntGraphType>>("Company_Name");

        }
           
    }
}

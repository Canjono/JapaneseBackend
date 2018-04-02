using GraphQL.Types;
using JapaneseBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapaneseBackend.Middlewares.GraphQLTypes
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Isbn).Description("The isbn of the book.");
            Field(x => x.Name).Description("The name of the book.");
        }
    }
}

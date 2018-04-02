using GraphQL.Types;
using JapaneseBackend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapaneseBackend.Middlewares.GraphQLTypes
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery(IBookRepository bookRepository)
        {
            Field<BookType>("book",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType>() { Name = "isbn" }),
                resolve: context =>
                {
                    var id = context.GetArgument<string>("isbn");
                    return bookRepository.BookByIsbn(id);
                });

            Field<ListGraphType<BookType>>("books",
                resolve: context =>
                {
                    return bookRepository.AllBooks();
                });

            Field<StringGraphType>(
                name: "hello",
                resolve: context => "world"
            );
        }
    }
}

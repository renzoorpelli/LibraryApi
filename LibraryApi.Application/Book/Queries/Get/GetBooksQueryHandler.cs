using Dapper;
using LibraryApi.Domain.Entities;
using LibraryApi.Infrastructure.Persistence;
using MediatR;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi.Application.Book.Queries.Get
{
    /// <summary>
    /// handler/manejador del query de la IRequest
    /// </summary>
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<GetBooksQueryResponse>>
    {
        private readonly IOracleConnectionFactory _connectionFactory;

        public GetBooksQueryHandler(IOracleConnectionFactory oracleConnection)
        {
            this._connectionFactory = oracleConnection;
        }

        /// <summary>
        /// Metodo Handle() Interfez IRequestHandler() metodo encargado de manejar la request proveniente del metodo Send()
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<List<GetBooksQueryResponse>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<GetBooksQueryResponse> response2;
            using (OracleConnection oracleConnection = _connectionFactory.OracleCreateConnection())
            {
                const string sql = @"SELECT * FROM LIBROS";
                response2 = await oracleConnection.QueryAsync<GetBooksQueryResponse>(sql);
            }
            return response2.ToList();

        }
    }
}

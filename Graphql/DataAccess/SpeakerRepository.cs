using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Graphql.DataAccess;
using GraphQL.Models;

namespace GraphQL.DataAccess
{
    public class SpeakerRepository :ISpeakerRepository
    {
        private readonly ConnectDatabase _connect;
        public SpeakerRepository(ConnectDatabase connect)
        {
            _connect = connect;
        }

        public async Task<Speaker> Find(string Id)
        {
            using IDbConnection connection = _connect.GetConnection();
            var query = @"SELECT * FROM SPEAKERS WHERE ID = :pId";

            var speaker = await connection.QueryFirstOrDefaultAsync<Speaker>(query, new { pId = Id });
            return speaker;
        }

        public async Task<IEnumerable<Speaker>> GetAll()
        {
            using IDbConnection connection = _connect.GetConnection();
            var query = @"SELECT * FROM SPEAKERS";

            var speakers = await connection.QueryAsync<Speaker>(query);
            return speakers;
        }

    }
}

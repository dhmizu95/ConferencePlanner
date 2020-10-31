using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.DataAccess;
using GraphQL.Models;
using HotChocolate;

namespace GraphQL.Queries
{
    public class SpeakerQuery
    {
        private readonly ISpeakerRepository _speaker;

        public SpeakerQuery(ISpeakerRepository speaker)
        {
            _speaker = speaker;
        }

        public async Task<IQueryable<Speaker>> GetSpeakers() => (IQueryable<Speaker>) await _speaker.GetAll();
    }
}

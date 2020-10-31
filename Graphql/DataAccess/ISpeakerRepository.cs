using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Models;

namespace GraphQL.DataAccess
{
    public interface ISpeakerRepository
    {
        Task<Speaker> Find(string Id);

        Task<IEnumerable<Speaker>> GetAll();
        // Task<Contact> FindLatest();
        // Task<IEnumerable<Contact>> GetAll();
        // void Add(Contact contact);
        // void Update(Contact contact);
        // void Remove(int id);
        // Contact GetFullContact(int id);
        // void Save(Contact contact);
    }
}

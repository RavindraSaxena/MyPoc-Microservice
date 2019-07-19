using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyPoc.Sql.Services
{
    public class PersonRepository
    {
        private IDbConnection _connection;

        public PersonRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<string> GetNames()
        {
            IEnumerable<string> names = Enumerable.Empty<string>();
            return _connection.Query<string>("SELECT name FROM Person");
        }
    }
}

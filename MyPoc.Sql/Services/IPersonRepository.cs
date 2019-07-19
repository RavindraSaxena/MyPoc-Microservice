using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPoc.Sql.Services
{
    interface IPersonRepository
    {
        IEnumerable<string> GetNames();
    }
}

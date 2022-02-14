using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Repositories.Repositories
{
    public class TheloaiRepository : BaseRepository<theloai>, ITheloaiRepository
    {
        private readonly ISession _session;
        public TheloaiRepository(ISession session) : base(session)
        {
            _session = session;
        }
    }
}

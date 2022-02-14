using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Repositories.Repositories
{
    public class LuotxemRepository : BaseRepository<luotxem>, ILuotxemRepository
    {
        private readonly ISession _session;
        public LuotxemRepository(ISession session) : base(session)
        {
            _session = session;
        }
    }
}

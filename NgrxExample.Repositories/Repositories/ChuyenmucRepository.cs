using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Repositories.Repositories
{
    public class ChuyenmucRepository : BaseRepository<chuyenmuc>, IChuyenmucRepository
    {
        private readonly ISession _session;
        public ChuyenmucRepository(ISession session) : base(session)
        {
            _session = session;
        }
    }
}

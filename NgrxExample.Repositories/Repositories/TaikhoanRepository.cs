using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Repositories.Repositories
{
    public class TaikhoanRepository : BaseRepository<taikhoan>, ITaikhoanRepository
    {
        private readonly ISession _session;
        public TaikhoanRepository(ISession session) : base(session)
        {
            _session = session;
        }
    }
}

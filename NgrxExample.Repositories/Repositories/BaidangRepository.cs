using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NHibernate;

namespace NgrxExample.Repositories.Repositories
{
    public class BaidangRepository : BaseRepository<baidang>, IBaidangRepository
    {
        private readonly ISession _session;
        public BaidangRepository(ISession session) : base(session)
        {
            _session = session;
        }
    }
}

using NgrxExample.Repositories.IRepositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NgrxExample.Repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBaidangRepository BaidangRepository { get; }
        public IChuyenmucRepository ChuyenmucRepository { get; }
        public ILuotxemRepository LuotxemRepository { get; }
        public ITaikhoanRepository TaikhoanRepository { get; }
        public ITheloaiRepository TheloaiRepository { get; }
        private readonly ISessionFactory _sessionFactory;
        private readonly ITransaction _transaction;
        public ISession Session { get; private set; }

        public UnitOfWork(ISessionFactory sessionFactory, IBaidangRepository baidangRepository,
            IChuyenmucRepository chuyenmucRepository, ILuotxemRepository luotxemRepository,
            ITaikhoanRepository taikhoanRepository, ITheloaiRepository theloaiRepository)
        {
            this._sessionFactory = sessionFactory;
            this.Session = _sessionFactory.OpenSession();
            this.Session.FlushMode = FlushMode.Auto;
            this._transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);

            this.BaidangRepository = baidangRepository;
            this.ChuyenmucRepository = chuyenmucRepository;
            this.LuotxemRepository = luotxemRepository;
            this.TaikhoanRepository = taikhoanRepository;
            this.TheloaiRepository = theloaiRepository;
        }

        public void Dispose()
        {
            if (Session.IsOpen)
            {
                Session.Close();
            }
        }

        public void Commit()
        {
            if (!_transaction.IsActive)
            {
                throw new InvalidOperationException("No active transation");
            }

            _transaction.Commit();
        }

        public void Rollback()
        {
            if (_transaction.IsActive)
            {
                _transaction.Rollback();
            }
        }

    }
}

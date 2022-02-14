using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IBaidangRepository BaidangRepository { get; }
        public IChuyenmucRepository ChuyenmucRepository { get; }
        public ILuotxemRepository LuotxemRepository { get; }
        public ITaikhoanRepository TaikhoanRepository { get; }
        public ITheloaiRepository TheloaiRepository { get; }
        void Commit();
        void Rollback();
    }
}

using NgrxExample.Enttites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgrxExample.Service.IService
{
    public interface ITaikhoanService
    {
        IQueryable<taikhoan> GetAll();
        taikhoan GetbyKey(int id);
        bool CreateNew(taikhoan entity);
        bool Update(taikhoan entity);
        bool Delete(taikhoan entity);
    }
}

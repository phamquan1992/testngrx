using NgrxExample.Enttites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgrxExample.Service.IService
{
    public interface IBaidangService
    {
        IQueryable<baidang> GetAll();
        baidang GetbyKey(int id);
        bool CreateNew(baidang entity);
        bool Update(baidang entity);
        bool Delete(baidang entity);
    }
}

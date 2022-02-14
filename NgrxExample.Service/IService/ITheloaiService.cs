using NgrxExample.Enttites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgrxExample.Service.IService
{
    public interface ITheloaiService
    {
        IQueryable<theloai> GetAll();
        theloai GetbyKey(int id);
        bool CreateNew(theloai entity);
        bool Update(theloai entity);
        bool Delete(theloai entity);
    }
}

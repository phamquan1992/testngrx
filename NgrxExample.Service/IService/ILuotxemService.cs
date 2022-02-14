using NgrxExample.Enttites;
using System.Linq;

namespace NgrxExample.Service.IService
{
    public interface ILuotxemService
    {
        IQueryable<luotxem> GetAll();
        luotxem GetbyKey(int id);
        bool CreateNew(luotxem entity);
        bool Update(luotxem entity);
        bool Delete(luotxem entity);
    }
}

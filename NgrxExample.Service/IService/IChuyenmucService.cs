using NgrxExample.Enttites;
using System.Linq;

namespace NgrxExample.Service.IService
{
    public interface IChuyenmucService
    {
        IQueryable<chuyenmuc> GetAll();
        chuyenmuc GetbyKey(int id);
        bool CreateNew(chuyenmuc entity);
        bool Update(chuyenmuc entity);
        bool Delete(chuyenmuc entity);
    }
}

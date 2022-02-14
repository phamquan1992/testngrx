using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NgrxExample.Service.IService;
using System.Linq;

namespace NgrxExample.Service.ServiceImp
{
    public class LuotxemService : ILuotxemService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LuotxemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<luotxem> GetAll()
        {
            return _unitOfWork.LuotxemRepository.GetAll();
        }
        public luotxem GetbyKey(int id)
        {
            return _unitOfWork.LuotxemRepository.FindBy(id);
        }
        public bool CreateNew(luotxem entity)
        {
            try
            {
                _unitOfWork.LuotxemRepository.Add(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Update(luotxem entity)
        {
            try
            {
                _unitOfWork.LuotxemRepository.Update(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(luotxem entity)
        {
            try
            {
                _unitOfWork.LuotxemRepository.Delete(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}

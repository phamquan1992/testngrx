using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NgrxExample.Service.IService;
using System.Linq;

namespace NgrxExample.Service.ServiceImp
{
    public class TheloaiService : ITheloaiService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TheloaiService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<theloai> GetAll()
        {
            return _unitOfWork.TheloaiRepository.GetAll();
        }
        public theloai GetbyKey(int id)
        {
            return _unitOfWork.TheloaiRepository.FindBy(id);
        }
        public bool CreateNew(theloai entity)
        {
            try
            {
                _unitOfWork.TheloaiRepository.Add(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Update(theloai entity)
        {
            try
            {
                _unitOfWork.TheloaiRepository.Update(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(theloai entity)
        {
            try
            {
                _unitOfWork.TheloaiRepository.Delete(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}

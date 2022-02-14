using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NgrxExample.Service.IService;
using System.Linq;

namespace NgrxExample.Service.ServiceImp
{
    public class ChuyenmucService : IChuyenmucService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChuyenmucService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<chuyenmuc> GetAll()
        {
            return _unitOfWork.ChuyenmucRepository.GetAll();
        }
        public chuyenmuc GetbyKey(int id)
        {
            return _unitOfWork.ChuyenmucRepository.FindBy(id);
        }
        public bool CreateNew(chuyenmuc entity)
        {
            try
            {
                _unitOfWork.ChuyenmucRepository.Add(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Update(chuyenmuc entity)
        {
            try
            {
                _unitOfWork.ChuyenmucRepository.Update(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(chuyenmuc entity)
        {
            try
            {
                _unitOfWork.ChuyenmucRepository.Delete(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}

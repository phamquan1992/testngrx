using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NgrxExample.Service.IService;
using System.Linq;

namespace NgrxExample.Service.ServiceImp
{
    public class BaidangService : IBaidangService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BaidangService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<baidang> GetAll()
        {
            return _unitOfWork.BaidangRepository.GetAll();
        }
        public baidang GetbyKey(int id)
        {
            return _unitOfWork.BaidangRepository.FindBy(id);
        }
        public bool CreateNew(baidang entity)
        {
            try
            {
                _unitOfWork.BaidangRepository.Add(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Update(baidang entity)
        {
            try
            {
                _unitOfWork.BaidangRepository.Update(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(baidang entity)
        {
            try
            {
                _unitOfWork.BaidangRepository.Delete(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}

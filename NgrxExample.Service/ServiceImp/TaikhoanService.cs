using NgrxExample.Enttites;
using NgrxExample.Repositories.IRepositories;
using NgrxExample.Service.IService;
using System.Linq;

namespace NgrxExample.Service.ServiceImp
{
    public class TaikhoanService : ITaikhoanService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaikhoanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IQueryable<taikhoan> GetAll()
        {
            return _unitOfWork.TaikhoanRepository.GetAll();
        }
        public taikhoan GetbyKey(int id)
        {
            return _unitOfWork.TaikhoanRepository.FindBy(id);
        }
        public bool CreateNew(taikhoan entity)
        {
            try
            {
                _unitOfWork.TaikhoanRepository.Add(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Update(taikhoan entity)
        {
            try
            {
                _unitOfWork.TaikhoanRepository.Update(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool Delete(taikhoan entity)
        {
            try
            {
                _unitOfWork.TaikhoanRepository.Delete(entity);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}

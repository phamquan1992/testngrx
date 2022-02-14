using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NgrxExample.Enttites;
using NgrxExample.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgrxExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaikhoanController : ControllerBase
    {
        private readonly ITaikhoanService taikhoanService;
        public TaikhoanController(ITaikhoanService _ITaikhoanService)
        {
            taikhoanService = _ITaikhoanService;
        }
        [HttpGet]
        public IEnumerable<taikhoan> Get()
        {
            return taikhoanService.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public taikhoan GetbyKey(int id)
        {
            return taikhoanService.GetbyKey(id);
        }
        [HttpPost]
        [Route("Create")]
        public bool CreateNew([FromBody] taikhoan entity)
        {
            return taikhoanService.CreateNew(entity);
        }
        [HttpPut]
        [Route("Edit")]
        public bool Update([FromBody] taikhoan entity)
        {
            return taikhoanService.Update(entity);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            var obj = taikhoanService.GetbyKey(id);
            if (obj == null)
                return false;
            return taikhoanService.Delete(obj);
        }
    }
}

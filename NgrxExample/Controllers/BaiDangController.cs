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
    public class BaiDangController : ControllerBase
    {
        private readonly IBaidangService baidangService;
        public BaiDangController(IBaidangService _IBaidangService)
        {
            baidangService = _IBaidangService;
        }
        [HttpGet]
        public IEnumerable<baidang> Get()
        {
            return baidangService.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public baidang GetbyKey(int id)
        {
            return baidangService.GetbyKey(id);
        }
        [HttpPost]
        [Route("Create")]
        public bool CreateNew([FromBody] baidang entity)
        {
            return baidangService.CreateNew(entity);
        }
        [HttpPut]
        [Route("Edit")]
        public bool Update([FromBody] baidang entity)
        {
            return baidangService.Update(entity);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            var obj = baidangService.GetbyKey(id);
            if (obj == null)
                return false;
            return baidangService.Delete(obj);
        }
    }
}

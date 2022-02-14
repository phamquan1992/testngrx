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
    public class LuotXemController : ControllerBase
    {
        private readonly ILuotxemService luotxemService;
        public LuotXemController(ILuotxemService _ILuotxemService)
        {
            luotxemService = _ILuotxemService;
        }
        [HttpGet]
        public IEnumerable<luotxem> Get()
        {
            return luotxemService.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public luotxem GetbyKey(int id)
        {
            return luotxemService.GetbyKey(id);
        }
        [HttpPost]
        [Route("Create")]
        public bool CreateNew([FromBody] luotxem entity)
        {
            return luotxemService.CreateNew(entity);
        }
        [HttpPut]
        [Route("Edit")]
        public bool Update([FromBody] luotxem entity)
        {
            return luotxemService.Update(entity);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            var obj = luotxemService.GetbyKey(id);
            if (obj == null)
                return false;
            return luotxemService.Delete(obj);
        }
    }
}

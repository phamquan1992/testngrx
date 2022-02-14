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
    public class TheLoaiController : ControllerBase
    {
        private readonly ITheloaiService theloaiService;
        public TheLoaiController(ITheloaiService _ITheloaiService)
        {
            theloaiService = _ITheloaiService;
        }
        [HttpGet]
        public IEnumerable<theloai> Get()
        {
            return theloaiService.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public theloai GetbyKey(int id)
        {
            return theloaiService.GetbyKey(id);
        }
        [HttpPost]
        [Route("Create")]
        public bool CreateNew([FromBody] theloai entity)
        {
            return theloaiService.CreateNew(entity);
        }
        [HttpPut]
        [Route("Edit")]
        public bool Update([FromBody] theloai entity)
        {
            return theloaiService.Update(entity);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            var obj = theloaiService.GetbyKey(id);
            if (obj == null)
                return false;
            return theloaiService.Delete(obj);
        }
    }
}

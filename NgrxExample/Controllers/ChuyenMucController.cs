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
    public class ChuyenMucController : ControllerBase
    {
        private readonly IChuyenmucService chuyenmucService;
        public ChuyenMucController(IChuyenmucService _IChuyenmucService)
        {
            chuyenmucService = _IChuyenmucService;
        }
        [HttpGet]
        public IEnumerable<chuyenmuc> Get()
        {
            return chuyenmucService.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public chuyenmuc GetbyKey(int id)
        {
            return chuyenmucService.GetbyKey(id);
        }
        [HttpPost]
        [Route("Create")]
        public bool CreateNew([FromBody] chuyenmuc entity)
        {
            return chuyenmucService.CreateNew(entity);
        }
        [HttpPut]
        [Route("Edit")]
        public bool Update([FromBody] chuyenmuc entity)
        {
            return chuyenmucService.Update(entity);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            var obj = chuyenmucService.GetbyKey(id);
            if (obj == null)
                return false;
            return chuyenmucService.Delete(obj);
        }
    }
}

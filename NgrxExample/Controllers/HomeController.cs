using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NgrxExample.Enttites.Domain2;
using NgrxExample.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgrxExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IBaidangService baidangService;
        private readonly IChuyenmucService chuyenmucService;
        private readonly ITaikhoanService taikhoanService;
        private readonly ITheloaiService theloaiService;
        public HomeController(IBaidangService _baidangService, IChuyenmucService _chuyenmucService, ITaikhoanService _taikhoanService, ITheloaiService _theloaiService)
        {
            baidangService = _baidangService;
            chuyenmucService = _chuyenmucService;
            taikhoanService = _taikhoanService;
            theloaiService = _theloaiService;
        }
        [HttpGet]
        public InfoHome Get()
        {
            InfoHome obj = new InfoHome();
            obj.countBd = baidangService.GetAll().Count();
            obj.countCm = chuyenmucService.GetAll().Count();
            obj.countTk = taikhoanService.GetAll().Count();
            obj.countTl = theloaiService.GetAll().Count();
            return obj;
        }
    }
}

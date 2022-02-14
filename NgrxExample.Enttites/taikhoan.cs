using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Enttites
{
    public class taikhoan
    {
        public virtual int idtaikhoan { get; set; }
        public virtual string tentaikhoan { get; set; }
        public virtual string matkhau { get; set; }
        public virtual string hoten { get; set; }
        public virtual DateTime? ngaysinh { get; set; }
        public virtual string gioitinh { get; set; }
        public virtual string email { get; set; }
        public virtual string diachi { get; set; }
        public virtual string sdt { get; set; }
        public virtual string anhdaidien { get; set; }
        public virtual string trangthainguoidung { get; set; }
        public virtual string quyenhan { get; set; }
    }
}

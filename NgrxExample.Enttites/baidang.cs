using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Enttites
{
    public class baidang
    {
        public virtual int idbaidang { get; set; }
        public virtual string tenbaidang { get; set; }
        public virtual string tieude { get; set; }
        public virtual string urlrequire { get; set; }
        public virtual string anhdaidien { get; set; }
        public virtual string noidung { get; set; }
        public virtual int idtaikhoan { get; set; }
        public virtual DateTime? ngaydang { get; set; }
        public virtual string trangthaibaidang { get; set; }
        public virtual int idtheloai { get; set; }
    }
}

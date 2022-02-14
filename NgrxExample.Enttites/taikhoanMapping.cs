using FluentNHibernate.Mapping;

namespace NgrxExample.Enttites
{
    public class taikhoanMapping:ClassMap<taikhoan>
    {
        public taikhoanMapping()
        {
            Table("taikhoan");
            Id(x => x.idtaikhoan).GeneratedBy.Identity();
            Map(x => x.anhdaidien).Nullable();
            Map(x => x.diachi).Nullable();
            Map(x => x.email).Nullable();
            Map(x => x.gioitinh).Nullable();
            Map(x => x.hoten).Nullable();
            Map(x => x.matkhau).Nullable();
            Map(x => x.ngaysinh).Nullable();
            Map(x => x.quyenhan).Nullable();
            Map(x => x.sdt).Nullable();
            Map(x => x.tentaikhoan).Nullable();
            Map(x => x.trangthainguoidung).Nullable();
        }
    }
}

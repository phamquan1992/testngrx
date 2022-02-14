using FluentNHibernate.Mapping;

namespace NgrxExample.Enttites
{
    public class baidangMapping : ClassMap<baidang>
    {
        public baidangMapping()
        {
            Table("baidang");
            Id(x => x.idbaidang).GeneratedBy.Identity();
            Map(x => x.anhdaidien).Nullable();
            Map(x => x.idtaikhoan).Nullable();
            Map(x => x.idtheloai).Nullable();
            Map(x => x.ngaydang).Not.Nullable();
            Map(x => x.noidung).Not.Nullable();
            Map(x => x.tenbaidang).Not.Nullable();
            Map(x => x.tieude).Not.Nullable();
            Map(x => x.trangthaibaidang).Nullable();
            Map(x => x.urlrequire).Nullable();
        }
    }
}

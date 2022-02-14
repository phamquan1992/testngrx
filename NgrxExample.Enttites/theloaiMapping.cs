using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Enttites
{
    public class theloaiMapping: ClassMap<theloai>
    {
        public theloaiMapping()
        {
            Table("theloai");
            Id(x => x.idtheloai).GeneratedBy.Identity();
            Map(x => x.tentheloai).Not.Nullable();
            Map(x => x.urlrequire).Nullable();
        }
    }
}

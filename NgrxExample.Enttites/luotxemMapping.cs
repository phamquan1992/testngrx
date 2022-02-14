using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Enttites
{
    public class luotxemMapping:ClassMap<luotxem>
    {
        public luotxemMapping()
        {
            Table("luotxem");
            Id(x => x.id).GeneratedBy.Identity();
            Map(x => x.idbaidang).Not.Nullable();
            Map(x => x.ngaythang).Not.Nullable();
        }
    }
}

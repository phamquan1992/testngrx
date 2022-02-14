using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NgrxExample.Enttites
{
    public class chuyenmucMapping:ClassMap<chuyenmuc>
    {
        public chuyenmucMapping()
        {
            Table("chuyenmuc");
            Id(x => x.idcm).GeneratedBy.Identity();
            Map(x => x.idcmcha).Nullable();
            Map(x => x.link).Nullable();
            Map(x => x.tencm).Not.Nullable();
        }
    }
}

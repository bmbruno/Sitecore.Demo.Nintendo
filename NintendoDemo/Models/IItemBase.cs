using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NintendoDemo.Models
{
    public interface IItemBase
    {
        [SitecoreId]
        Guid ItemID { get; set; }

        [SitecoreInfo(Type = SitecoreInfoType.FullPath)]
        string FullPath { get; set; }

        [SitecoreField("__SortOrder")]
        int SortOrder { get; set; }
    }
}
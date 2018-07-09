using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NintendoDemo.Models
{
    [SitecoreType(TemplateId = "{B8D9EE77-8471-4470-81C1-9EC4D240B6D5}", AutoMap = true)]
    public interface IGame : IItemBase
    {
        [SitecoreField]
        string Name { get; set; }

        [SitecoreField]
        DateTime ReleaseDate { get; set; }

        [SitecoreField]
        Glass.Mapper.Sc.Fields.Image Boxart { get; set; }
    }
}

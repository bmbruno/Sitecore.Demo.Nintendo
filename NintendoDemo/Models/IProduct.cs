using Glass.Mapper.Sc.Configuration.Attributes;
using System;

namespace NintendoDemo.Models
{
    [SitecoreType(TemplateId = "{68510961-6F07-4F5A-B0D7-9B117FA03E94}", AutoMap = true)]
    public interface IProduct : IItemBase
    {
        [SitecoreField]
        string Name { get; set; }

        [SitecoreField(FieldName = "Release Date")]
        DateTime ReleaseDate { get; set; }

        [SitecoreField]
        Glass.Mapper.Sc.Fields.Image Image { get; set; }

        [SitecoreField]
        string About { get; set; }

        [SitecoreField(FieldName = "Active Production")]
        bool ActiveProduction { get; set; }

        [SitecoreField(FieldName = "Marketing Page URL")]
        Glass.Mapper.Sc.Fields.Link MarketingPageURL { get; set; }

        [SitecoreField(FieldName = "Detail Page URL")]
        Glass.Mapper.Sc.Fields.Link DetailPageURL { get; set; }

    }
}
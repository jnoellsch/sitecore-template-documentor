namespace SitecoreDocumentor.Web.Models
{
    using System;

    [Serializable]
    public class RenderingMetaItem : ModelBase
    {
        public string Description { get; set; }
        public string Icon { get; set; }
        public string ThumbnailImage { get; set; }
        public string FullImage { get; set; }
        public TemplateMetaItem DataSourceTemplate { get; set; }
        public string DataSourceLocation { get; set; }
    }
}
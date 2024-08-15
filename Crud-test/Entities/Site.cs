using System.ComponentModel.DataAnnotations;

namespace CodeMonkeys.CMS.Public.Shared.Entities
{
    public class Site
    {
        [Key]
        public int SiteID { get; set; }
        required public string Name { get; set; }
        required public DateTime CreatedDate { get; set; }
        required public DateTime LastModifiedDate { get; set; }

        public ICollection<WebPage> Pages { get; set; } = new List<WebPage>();
    }
}
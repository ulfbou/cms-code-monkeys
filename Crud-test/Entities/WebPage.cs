namespace CodeMonkeys.CMS.Public.Shared.Entities
{
    public class WebPage
    {
        public int Id { get; set; }
        required public string Title { get; set; }
        required public DateTime CreatedDate { get; set; }
        required public DateTime LastModifiedDate { get; set; }

        public int? SiteId { get; set; }
        public Guid? UserId { get; set; }

        public ICollection<Content> Contents { get; set; } = new List<Content>();
    }
}
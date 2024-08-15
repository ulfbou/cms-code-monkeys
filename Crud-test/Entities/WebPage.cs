namespace CodeMonkeys.CMS.Public.Shared.Entities
{
    public class WebPage
    {
        public int Id { get; set; }
         public string Title { get; set; }
         public DateTime CreatedDate { get; set; }
         public DateTime LastModifiedDate { get; set; }

        public int? SiteId { get; set; }
        public Guid? UserId { get; set; }

        public ICollection<Content> Contents { get; set; } = new List<Content>();
    }
}
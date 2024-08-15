namespace CodeMonkeys.CMS.Public.Shared.Entities
{
    public class Content
    {
        public int Id { get; set; }
         public string Title { get; set; }
         public string ContentType { get; set; }
         public string Body { get; set; }
         public DateTime CreatedDate { get; set; }
         public DateTime LastModifiedDate { get; set; }

        public int? PageId { get; set; }
    }
}

using System;

namespace Article.Domain.Entities;

public class Article
{
    public int Id { get; set; }
    public List<Like> Likes { get; set;} = new List<Like>();
}
public class Like
{
    public int ArticleId { get; set; }
    public int UserId { get; set; }
    public DateTime LikedAt { get; set; }  // Timestamp for rate limiting
}

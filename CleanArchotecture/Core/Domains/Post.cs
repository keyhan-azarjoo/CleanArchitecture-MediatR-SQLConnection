namespace Core.Domains;

public class Post : Base
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public IEnumerable<Comment> Comments { get; set; }
}


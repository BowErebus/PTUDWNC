namespace TatBlog.Core.DTO;

public class CategoryItem
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string UrlSlug { get; set; }

    public string Description { get; set; }

    public bool ShowOnMenu { get; set; }

    public int PostCount { get; set; }
}
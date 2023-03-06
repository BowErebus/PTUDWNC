using TatBlog.Core.Entities;
using TatBlog.Data.Contexts;

namespace TatBlog.Data.Seeders;

public class DataSeeder : IDataSeeder
{
    private readonly BlogDbContext _dbContext;

    public DataSeeder(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Initialize()
    {
        _dbContext.Database.EnsureCreated();

        if (_dbContext.Posts.Any()) return;

        var authors = AddAuthors();
        var categories = AddCategories();
        var tags = AddTags();
        var posts = AddPosts(authors, categories, tags);
    }

    private IList<Author> AddAuthors() 
    {
        var authors = new List<Author>()
        {
            new()
            {
                FullName = "Jason Mouth",
                UrlSlug = "jason-mouth",
                Email = "json@gmail.com",
                JoinedDate = new DateTime(2022, 10, 21)
            },
            new()
            {
                FullName = "Jessica Wonder",
                UrlSlug = "jesscica-wonder",
                Email = "jessica665@motip.com",
                JoinedDate = new DateTime(2020, 4, 19)
            },
            new()
            {
                FullName = "James Litta",
                UrlSlug = "james-litta",
                Email = "jameslitta@gmail.com",
                JoinedDate = new DateTime(2021, 1, 19)
            },
            new()
            {
                FullName = "Loda Smite",
                UrlSlug = "loda-smite",
                Email = "lodasmite@gmail.com",
                JoinedDate = new DateTime(2022, 6, 1)
            },
            new()
            {
                FullName = "Jessica Meta",
                UrlSlug = "jesscica-meta",
                Email = "jmeta@motip.com",
                JoinedDate = new DateTime(2021, 10, 10)
            }
        };
        
        _dbContext.Authors.AddRange(authors);
        _dbContext.SaveChanges();

        return authors;
    }

    private IList<Category> AddCategories()
    {
        var categories = new List<Category>()
        {
            new() {Name = ".NET Core", Description = ".NET Core", UrlSlug = "net-core", ShowOnMenu = true},
            new() {Name = "Architecture", Description = "Architecture", UrlSlug = "architecture", ShowOnMenu = true},
            new() {Name = "Messaging", Description = "Messaging", UrlSlug = "messaging", ShowOnMenu = true},
            new() {Name = "OOP", Description = "Object-Oriented Programing", UrlSlug = "object-oriented-programing", ShowOnMenu = true},
            new() {Name = "Design Patterns", Description = "Design Patterns", UrlSlug = "design-patterns", ShowOnMenu = true},
            new() {Name = "C", Description = "C", UrlSlug = "c", ShowOnMenu = true},
            new() {Name = "C#", Description = "C Shape", UrlSlug = "c-shape", ShowOnMenu = true},
            new() {Name = "C++", Description = "C Plus Plus", UrlSlug = "c-plus-plus", ShowOnMenu = true},
            new() {Name = "React", Description = "React", UrlSlug = "react", ShowOnMenu = true},
            new() {Name = "ReactJS", Description = "React JavaScript", UrlSlug = "react-javascript", ShowOnMenu = true}
        };

        _dbContext.AddRange(categories);
        _dbContext.SaveChanges();

        return categories;
    }

    private IList<Tag> AddTags() 
    {
        var tags = new List<Tag>()
        {
            new() {Name = "Google", Description = "Google applications", UrlSlug = "google-applications"},
            new() {Name = "ASP.NET MVC", Description = "ASP.NET MVC", UrlSlug = "asp-mvc"},
            new() {Name = "Razor Page", Description = "Razor Page", UrlSlug = "razor-page"},
            new() {Name = "Blazor", Description = "Blazor", UrlSlug = "blazor"},
            new() {Name = "Deep Learning", Description = "Deep Learning", UrlSlug = "deep-learning"},
            new() {Name = "Neural Network", Description = "Neural Network", UrlSlug = "neural-network"},
            new() {Name = "Chrome", Description = "Chrome applications", UrlSlug = "chrome-applications"},
            new() {Name = "MVC", Description = "Model-View-Controller", UrlSlug = "model-view-controller"},
            new() {Name = "Black Page", Description = "Black Page", UrlSlug = "black-page"},
            new() {Name = "Blade", Description = "Blade", UrlSlug = "blade"},
            new() {Name = "Deep Web", Description = "Deep Web", UrlSlug = "deep-web"},
            new() {Name = "Network", Description = "Network", UrlSlug = "network"},
            new() {Name = "FireFox", Description = "FireFox applications", UrlSlug = "firefox-applications"},
            new() {Name = "ASP.NET", Description = "ASP.NET", UrlSlug = "aspnet"},
            new() {Name = "Raze Page", Description = "Raze Page", UrlSlug = "raze-page"},
            new() {Name = "Blazor", Description = "Blazor", UrlSlug = "blazor"},
            new() {Name = "English Learning", Description = "English Learning", UrlSlug = "english-learning"},
            new() {Name = "Auto Network", Description = "Auto Network", UrlSlug = "auto-network"},
            new() {Name = "C Learning", Description = "C Learning", UrlSlug = "c-learning"},
            new() {Name = "All Network", Description = "All Network", UrlSlug = "all-network"}
        };

        _dbContext.AddRange(tags);
        _dbContext.SaveChanges();

        return tags;
    }

    private IList<Post> AddPosts(
        IList<Author> authors,
        IList<Category> categories,
        IList<Tag> tags)
    {
        var posts = new List<Post>()
        {
            new()
            {
                Title = "ASP.NET Core Diagnostic Scenarios",
                ShortDescription = "David and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "David and friends has a great repository filled",
                UrlSlug = "aspnet-core-diagnostic-scenarios",
                Published = true,
                PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Google Application",
                ShortDescription = "Khan and friends has a great application",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Khan and friends has a great application filled",
                UrlSlug = "google-application",
                Published = true,
                PostedDate = new DateTime(2022, 1, 22, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "C",
                ShortDescription = "Ami and friends has a great program",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Ami and friends has a great program filled",
                UrlSlug = "c",
                Published = true,
                PostedDate = new DateTime(2022, 9, 2, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "C Shape",
                ShortDescription = "Xiao and friends has a great program",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Xiao and friends has a great program filled",
                UrlSlug = "C Shape",
                Published = true,
                PostedDate = new DateTime(2021, 1, 22, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "C Plus Plus",
                ShortDescription = "Ning and friends has a great program",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Ning and friends has a great program filled",
                UrlSlug = "c-plus-plus",
                Published = true,
                PostedDate = new DateTime(2020, 5, 24, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Chrome Application",
                ShortDescription = "Bill and friends has a great application",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Bill and friends has a great application filled",
                UrlSlug = "chrome-application",
                Published = true,
                PostedDate = new DateTime(2022, 10, 9, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "FireFox Application",
                ShortDescription = "Leo and friends has a great application",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Leo and friends has a great application filled",
                UrlSlug = "firefox-application",
                Published = true,
                PostedDate = new DateTime(2021, 3, 3, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "ASP.NET MVC",
                ShortDescription = "Jum and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Jum and friends has a great repository filled",
                UrlSlug = "aspnet-core-model-view-controller",
                Published = true,
                PostedDate = new DateTime(2021, 12, 5, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Razor Page",
                ShortDescription = "Teg and friends has a great page",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Teg and friends has a great page filled",
                UrlSlug = "razor-page",
                Published = true,
                PostedDate = new DateTime(2021, 8, 2, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Blazor",
                ShortDescription = "Thy and friends has a great application",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Thy and friends has a great application filled",
                UrlSlug = "blazor",
                Published = true,
                PostedDate = new DateTime(2021, 9, 1, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Deep Learning",
                ShortDescription = "Hoang and friends has a great application",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Hoang and friends has a great application filled",
                UrlSlug = "deep-learning",
                Published = true,
                PostedDate = new DateTime(2021, 1, 30, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Neural Network",
                ShortDescription = "Viktor and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Viktor and friends has a great repository filled",
                UrlSlug = "neural-network",
                Published = true,
                PostedDate = new DateTime(2021, 2, 4, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Object-Oriented Programing",
                ShortDescription = "Saga and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Saga and friends has a great repository filled",
                UrlSlug = "object-oriented-programing",
                Published = true,
                PostedDate = new DateTime(2021, 4, 30, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Design Pattens",
                ShortDescription = "Jenny and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Jenny and friends has a great repository filled",
                UrlSlug = "design-pattens",
                Published = true,
                PostedDate = new DateTime(2021, 2, 9, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Architecture",
                ShortDescription = "Mina and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Mina and friends has a great repository filled",
                UrlSlug = "architecture",
                Published = true,
                PostedDate = new DateTime(2021, 5, 8, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Messaging",
                ShortDescription = "Ken and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Ken and friends has a great repository filled",
                UrlSlug = "messaging",
                Published = true,
                PostedDate = new DateTime(2021, 4, 5, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "React",
                ShortDescription = "Nickey and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Nickey and friends has a great repository filled",
                UrlSlug = "react",
                Published = true,
                PostedDate = new DateTime(2021, 10, 10, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "ReactJS",
                ShortDescription = "Lam and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Lam and friends has a great repository filled",
                UrlSlug = "reactjs",
                Published = true,
                PostedDate = new DateTime(2021, 5, 2, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Python",
                ShortDescription = "Geoger and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Geoger and friends has a great repository filled",
                UrlSlug = "python",
                Published = true,
                PostedDate = new DateTime(2021, 3, 3, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Window 10",
                ShortDescription = "Kevin and friends has a great operating system",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Kevin and friends has a great repository filled",
                UrlSlug = "window-10",
                Published = true,
                PostedDate = new DateTime(2021, 6, 10, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Window 7",
                ShortDescription = "Janis and friends has a great operating system",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Janis and friends has a great repository filled",
                UrlSlug = "window-7",
                Published = true,
                PostedDate = new DateTime(2021, 8, 10, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Window 11",
                ShortDescription = "Huin and friends has a great operating system",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Huin and friends has a great operating system filled",
                UrlSlug = "window-11",
                Published = true,
                PostedDate = new DateTime(2021, 9, 11, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Model View Controller",
                ShortDescription = "Nati and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Nati and friends has a great repository filled",
                UrlSlug = "model-view-controller",
                Published = true,
                PostedDate = new DateTime(2021, 10, 1, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Data Access",
                ShortDescription = "Luci and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Luci and friends has a great repository filled",
                UrlSlug = "data-access",
                Published = true,
                PostedDate = new DateTime(2021, 3, 7, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "DriverPack",
                ShortDescription = "Max and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Max and friends has a great repository filled",
                UrlSlug = "driverpack",
                Published = true,
                PostedDate = new DateTime(2021, 2, 11, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Unity Hub",
                ShortDescription = "Sara and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Sara and friends has a great repository filled",
                UrlSlug = "unity-hub",
                Published = true,
                PostedDate = new DateTime(2021, 5, 5, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Apache NetBeans IDE 15",
                ShortDescription = "Wu and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Wu and friends has a great repository filled",
                UrlSlug = "apache-netbeans-ide-15",
                Published = true,
                PostedDate = new DateTime(2021, 6, 22, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Android Studio",
                ShortDescription = "Jin and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Jin and friends has a great repository filled",
                UrlSlug = "android-studio",
                Published = true,
                PostedDate = new DateTime(2021, 9, 1, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Notepad",
                ShortDescription = "Mon and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Mon and friends has a great repository filled",
                UrlSlug = "notepad",
                Published = true,
                PostedDate = new DateTime(2021, 2, 21, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            },
            new()
            {
                Title = "Recycle Bin",
                ShortDescription = "Bao and friends has a great repository",
                Description = "Here's a few great DONT'T and DO examples",
                Meta = "Bao and friends has a great repository filled",
                UrlSlug = "recycle-bin",
                Published = true,
                PostedDate = new DateTime(2021, 11, 11, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[0]
                }
            }
        };

        _dbContext.AddRange(posts);
        _dbContext.SaveChanges();

        return posts;
    }
}
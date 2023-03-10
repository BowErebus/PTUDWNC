using Microsoft.AspNetCore.Mvc;
using TatBlog.Services.Blogs;

namespace TatBlog.WebApp.Controllers
{
    public class BlogController : Controller
    {
        //private readonly IBlogRepository blogRepository;

        //public BlogController(IBlogRepository blogRepository)
        //{
        //    _blogRepository = blogRepository;
        //}

        public IActionResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now.ToString("HH:mm:ss");

            return View();
        }

        public IActionResult About()
            => View();

        public IActionResult Contract()
            => View();

        public IActionResult Rss()
            => Content("Nội dung sẽ được cập nhật");

        //// Action này xử lý HTTP request đến trang chủ của
        //// ứng dụng web hoặc tìm kiếm bài viết theo từ khóa
        //public async Task<IActionResult> Index(
        //    [FromQuery(Name = "p")] int pageNumber = 1,
        //    [FromQuery(Name = "ps")] int pageSize = 10)
        //{
        //    // Tạo đối tượng chứa các điều kiện truy vấn
        //    var postQuery = new PostQuery()
        //    {
        //        // Chỉ lấy những bài viết có trạng thái Published
        //        PublishedOnly = true
        //    };

        //    // Truy vấn các bài viết theo điều kiện đã tạo
        //    var postList = await _blogRepository
        //        .GetPagedPostsAsync(postQuery, pageNumber, pageSize);

        //    // Lưu lại điều kiện truy vấn để hiển thị trong View
        //    ViewBag.PostQuery = postQuery;

        //    // Truyền danh sách bài viết vào View để render ra HTML
        //    return View(postList);
        //}
    }
}